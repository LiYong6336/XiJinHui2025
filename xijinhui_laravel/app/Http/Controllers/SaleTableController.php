<?php

namespace App\Http\Controllers;

use App\Models\DiningTable;
use App\Models\ExchangeRate;
use App\Models\SaleTable;
use App\Http\Requests\StoreSaleTableRequest;
use App\Http\Requests\UpdateSaleTableRequest;
use App\Models\CustomerTopup;
use App\Models\PaymentMethod;
use App\Models\PayOwed;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class SaleTableController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $result = SaleTable::with(['payments', 'payments.paymentMethod', 'dining_table', 'user', 'sale_detail']);
        // Customer topup
        $customerTopups = CustomerTopup::query();
        $payOweds = PayOwed::query();

        if (request('search')) {
            $result = $result->where('remark', 'LIKE', '%' . request('search') . '%');
        }
        if (request('start_date')) {
            $result = $result->where('sale_date', '>=', Carbon::parse(request('start_date')));
            $customerTopups = $customerTopups->where('created_at', '>=', Carbon::parse(request('start_date')));
            $payOweds = $payOweds->where('paid_at', '>=', Carbon::parse(request('start_date')));
        }
        if (request('end_date')) {
            $result = $result->where('sale_date', '<=', Carbon::parse(request('end_date')));
            $customerTopups = $customerTopups->where('created_at', '<=', Carbon::parse(request('end_date')));
            $payOweds = $payOweds->where('paid_at', '<=', Carbon::parse(request('end_date')));
        }
        if (request()->has('owned')) {
            //$result = $result->where('user_id', auth()->user()->id);
        }
        if (request()->has('owe_status')) {
            if (request()->get('owe_status') == 'owed') {
                $result = $result->whereRaw('grand_total > (received_dollar + (received_riel*exchange_rate))')
                    ->whereDoesntHave('payOwed');
            } else {
                $result = $result->whereRaw('grand_total <= (received_dollar + (received_riel*exchange_rate))')
                    ->whereHas('payOwed');
            }
        }

        if (request()->has('is_secret')) {
            $result = $result->whereNotNull('invoice_number')->where('is_secret', true);
            $payOweds = $payOweds->whereHas('saleTable', function ($query) {
                $query->where('is_secret', true);
            });
        } else if (request()->has('is_public')) {
            $result = $result->where('is_secret', false)
                ->orderBy('showing_invoice_number', 'asc');
            $payOweds = $payOweds->whereHas('saleTable', function ($query) {
                $query->where('is_secret', false);
            });
        } else {
            $result = $result->whereNotNull('showing_invoice_number')->where('is_secret', false);
            $payOweds = $payOweds->whereHas('saleTable', function ($query) {
                $query->where('is_secret', false);
            });
        }

        $result = $result->orderBy('showing_invoice_number')
            ->orderBy('invoice_number')->get();
        $customerTopupAmount = $customerTopups->sum('topup_amount');
        $payOwedAmount = $payOweds->sum('amount');

        $returnDollar = 0;
        $returnRiel = 0;

        $total = 0;
        $payments = [];
        foreach ($result as $st) {
            $total += $st->grand_total;
            foreach ($st->payments as $pm) {
                $pmMethodId = $pm->paymentMethod->english_name;
                if (!isset($payments[$pmMethodId])) {
                    $payments[$pmMethodId] = [];
                }
                $payments[$pmMethodId]['riel'] = ($payments[$pmMethodId]['riel'] ?? 0) + $pm->amount_riel;
                $payments[$pmMethodId]['dollar'] = ($payments[$pmMethodId]['dollar'] ?? 0) + $pm->amount_dollar;
            }
            $returnDollar = $returnDollar + $st->return_dollars;
            $returnRiel = $returnRiel + $st->return_riels;
        }

        $payments['CASH'] = isset($payments['CASH']) ? $payments['CASH'] : ['riel' => 0, 'dollar' => 0];
        $payments['CASH']['riel'] = $payments['CASH']['riel'] - $returnRiel;
        $payments['CASH']['dollar'] = $payments['CASH']['dollar'] - $returnDollar;

        $paymentsStr = [];
        foreach ($payments as $k => $pm) {
            $paymentsStr[] = $k . ': ' . ($pm['dollar'] ?? 0) . '$ | ' . ($pm['riel'] ?? 0) . 'R';
        }


        return response()->json([
            "success" => true,
            "message" => "Successful Retrieved List",
            "data" => $result,
            'total_amount' => "$total",
            'total_amount2' => implode('\n', $paymentsStr),
            'total_by_methods' => $paymentsStr,
            'customer_topup' => "$customerTopupAmount",
            'pay_owed' => "$payOwedAmount",
        ], Response::HTTP_OK);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreSaleTableRequest $request)
    {
        //
    }

    /**
     * Display the specified resource.
     */
    public function show(SaleTable $saleTable)
    {
        $result = SaleTable::with('payments', 'dining_table', 'dining_table.dining_floor', 'user', 'sale_detail')
            ->where('id', $saleTable->id)->first();
        return HelperController::modelGetSingleSuccessfulMessage($result);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(SaleTable $saleTable)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateSaleTableRequest $request, SaleTable $saleTable)
    {
        $saleTable->update($request->validated());

        return HelperController::modelGetAllSuccessfuleMessage($saleTable->load('payments', 'dining_table', 'dining_table.dining_floor', 'user', 'sale_detail'));
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(SaleTable $saleTable)
    {
        if ($saleTable->is_secret) {
            return response([
                'message' => 'You can not delete secret sale',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        $saleTable->delete();

        return response([
            'message' => 'Sale have been deleted',
        ]);
    }

    public function cancel(Request $request, SaleTable $saleTable)
    {
        if ($saleTable->sale_detail()->count() > 0) {
            return response([
                'message' => 'You can not cancel invoice with existing items.',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        $saleTable->status_code = 3; //cancel
        $saleTable->finished_dining_date = now();
        $saleTable->take_time = now()->diffInMinutes($saleTable->created_at);
        $saleTable->save();
        return HelperController::modelGetSingleSuccessfulMessage($saleTable);
    }

    public function updateShowingInvoiceNumber(Request $request, SaleTable $saleTable)
    {
        $request->validate([
            'showing_invoice_number' => 'nullable|integer',
        ]);
        $saleTable->update([
            'showing_invoice_number' => $request->showing_invoice_number ? $saleTable->makeInvoiceNumber($request->showing_invoice_number) : null,
        ]);

        return HelperController::modelGetSingleSuccessfulMessage($saleTable->load(['payments', 'payments.paymentMethod', 'dining_table', 'user', 'sale_detail']));
    }

    public function payOwed(Request $request, SaleTable $saleTable)
    {
        $oweMethod = PaymentMethod::where('payment_url', 'owe')->first();
        if (!$oweMethod) {
            return response([
                'message' => 'You have no owe method',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        $owe = $saleTable->payments()->where('payment_method_id', $oweMethod->id)->first();
        if (!$owe) {
            return response([
                'message' => 'Sale is not owe',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        if ($saleTable->payOwed) {
            return response([
                'message' => 'Pay owed already created.',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        if ($request->amount != $saleTable->grand_total) {
            return response([
                'message' => 'Amount not match with grand total.',
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        $saleTable->createPayOwed($request->get('date', now()));

        return response([
            'message' => 'Payment have been make',
        ]);
    }
}
