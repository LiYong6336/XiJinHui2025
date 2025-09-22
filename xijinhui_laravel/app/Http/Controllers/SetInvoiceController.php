<?php

namespace App\Http\Controllers;

use App\Models\SetInvoice;
use App\Http\Requests\StoreSetInvoiceRequest;
use App\Http\Requests\UpdateSetInvoiceRequest;
use App\Models\SaleTable;

class SetInvoiceController extends Controller
{
    public function index()
    {
        $setInvoices = SetInvoice::latest()->take(100)->get();

        return HelperController::modelGetAllSuccessfuleMessage($setInvoices);
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
    public function store(StoreSetInvoiceRequest $request)
    {
        if ($request->invoice_start) {
            $number = $request->invoice_start;
        } else {
            $lastInvoice = SaleTable::whereNotNull('showing_invoice_number')->orderBy('showing_invoice_number', 'desc')->first();

            if (!$lastInvoice) {
                $number = 1;
            } else {
                $number = substr($lastInvoice->showing_invoice_number, 4);
                $number = intval($number);
            }
        }

        SetInvoice::create([
            'invoice_date' => $request->invoice_date,
            'invoice_count' => $request->invoice_count,
            'invoice_start' => $number,
            'invoice_end' => $number + $request->invoice_count,
        ]);

        return response([
            'message' => 'Invoice created',
        ]);
    }

    /**
     * Display the specified resource.
     */
    public function show(SetInvoice $setInvoice)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(SetInvoice $setInvoice)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateSetInvoiceRequest $request, SetInvoice $setInvoice)
    {
        if ($request->invoice_start) {
            $number = $request->invoice_start;
        } else {
            $lastInvoice = SaleTable::whereNotNull('showing_invoice_number')->orderBy('showing_invoice_number', 'desc')->first();

            if (!$lastInvoice) {
                $number = 1;
            } else {
                $number = substr($lastInvoice->showing_invoice_number, 4);
                $number = intval($number);
            }
        }

        $setInvoice->update([
            'invoice_date' => $request->invoice_date,
            'invoice_count' => $request->invoice_count,
            'invoice_start' => $number + 1,
            'invoice_end' => $number + $request->invoice_count,
        ]);
        return response([
            'message' => 'Invoice updated',
        ]);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(SetInvoice $setInvoice)
    {
        $setInvoice->delete();

        return response([
            'message' => 'Invoice deleted',
        ]);
    }
}
