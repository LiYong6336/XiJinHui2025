<?php

namespace App\Http\Controllers;

use App\Models\ExchangeRate;
use App\Http\Requests\StoreExchangeRateRequest;
use App\Http\Requests\UpdateExchangeRateRequest;

class ExchangeRateController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $exchange = ExchangeRate::latest()->get();
        return HelperController::modelGetAllSuccessfuleMessage($exchange);
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
    public function store(StoreExchangeRateRequest $request)
    {

        $exchange = ExchangeRate::create(
            [
                'exchange_date' => $request->get('exchange_date'),
                'rate_standard' => $request->get('rate_standard'),
                'rate_returned' => $request->get('rate_returned'),
                'rate_nssf' => $request->get('rate_nssf'),
                'rate_taxation' => $request->get('rate_taxation'),
            ]
        );
        return HelperController::modelCretedSuccessfuleMessage($exchange->refresh());
    }

    /**
     * Display the specified resource.
     */
    public function show(ExchangeRate $exchangeRate)
    {
        return HelperController::modelGetSingleSuccessfulMessage($exchangeRate);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(ExchangeRate $exchangeRate)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateExchangeRateRequest $request, ExchangeRate $exchangeRate)
    {
        $exchangeRate->update(
            [
                'exchange_date' => $request->get('exchange_date'),
                'rate_standard' => $request->get('rate_standard'),
                'rate_returned' => $request->get('rate_returned'),
                'rate_nssf' => $request->get('rate_nssf'),
                'rate_taxation' => $request->get('rate_taxation'),
            ]
        );
        return HelperController::modelCretedSuccessfuleMessage($exchangeRate->refresh());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(ExchangeRate $exchangeRate)
    {
        $exchangeRate->delete();
        return HelperController::modelDeleteSucessfulMessage($exchangeRate);
    }
}
