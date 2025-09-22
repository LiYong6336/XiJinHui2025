<?php

namespace App\Http\Controllers;

use App\Models\Payment;
use App\Http\Requests\StorePaymentRequest;
use App\Http\Requests\UpdatePaymentRequest;
use App\Models\SaleTable;
use Illuminate\Http\Request;

class PaymentController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index() {}

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
    public function store(StorePaymentRequest $request)
    {
        //
    }

    /**
     * Display the specified resource.
     */
    public function show(Payment $payment)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Payment $payment)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdatePaymentRequest $request, Payment $payment)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Payment $payment)
    {
        //
    }

    public function salePayment(StorePaymentRequest $request)
    {
        //return response($request->all(), 403);
        $sale_table = SaleTable::find($request->get('sale_table_id'));
        if ($sale_table) {
            foreach (($request->payments ?? []) as $p) {
                $payment = gettype($p) == 'string' ? json_decode($p, true) : $p;
                $sale_table->payments()->create([
                    'payment_method_id' => $payment['payment_method_id'],
                    'amount_dollar' => $payment['amount_dollar'],
                    'amount_riel' => $payment['amount_riel'],
                    'user_id' => auth()->user()->id,
                ]);
            }

            $sale_table = $sale_table->refresh();

            $isTip = $request->get('is_tip');
            $result =  $sale_table->received_dollar + ($sale_table->received_riel / $sale_table->exchange_rate)
                - $sale_table->grand_total;
            $result_interger = (int)$result;
            $result_decimal = $result - $result_interger;
            // update sale
            $sale_table->update([
                'invoice_number' => $sale_table->getNextInvoiceNumber(),
                'status_code' => 0,
                'finished_dining_date' => now(),
                'take_time' => now()->diffInMinutes($sale_table->sale_date),
                'balance_dollars' => $isTip ? $result : 0,
                'return_dollars' => $isTip ? 0 : $result_interger,
                'return_riels' => $isTip ? 0 : ($result_decimal * $sale_table->exchange_rate),
                'receipt_print_time' => 1,
                'making_status' => 0,
                'remark' => $request->remark,
            ]);


            $psale_table = $sale_table->duplicateForPublic($request->invoice_number);

            // report for receipt
            $sale_table->load(['payments', 'sale_detail', 'user', 'dining_table']);
            foreach ($sale_table->sale_detail as $sd) {

                if ($sd->food_dish_detail_id) {
                    foreach ($sd->foodDishDetail->foodIngredients as $foodIngredient) {
                        $ingredient = $foodIngredient->ingredient;
                        $ingredient->quantity = $ingredient->quantity - ($foodIngredient->usage * $sd->qty);
                        $ingredient->save();
                    }
                } else if ($sd->food_dish_id) {
                    foreach ($sd->foodDish->foodIngredients as $foodIngredient) {
                        $ingredient = $foodIngredient->ingredient;
                        $ingredient->quantity = $ingredient->quantity - ($foodIngredient->usage * $sd->qty);
                        $ingredient->save();
                    }
                }
            }

            $psale_table->load(['payments', 'sale_detail', 'user', 'dining_table']);

            return HelperController::modelCretedSuccessfuleMessage($psale_table, 'Payment Successful');
        }
        return HelperController::modelOperationErrorMessage('Not Found');
    }
}
