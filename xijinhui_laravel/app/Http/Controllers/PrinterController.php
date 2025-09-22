<?php

namespace App\Http\Controllers;

use App\Models\Printer;
use App\Http\Requests\StorePrinterRequest;
use App\Http\Requests\UpdatePrinterRequest;

class PrinterController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $printer=Printer::all();
        return HelperController::modelGetAllSuccessfuleMessage($printer);
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
    public function store(StorePrinterRequest $request)
    {
        $printer=Printer::create($request->validated());
        return HelperController::modelCretedSuccessfuleMessage($printer);
    }

    /**
     * Display the specified resource.
     */
    public function show(Printer $printer)
    {
        return HelperController::modelGetSingleSuccessfulMessage($printer);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Printer $printer)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdatePrinterRequest $request, Printer $printer)
    {
        $printer->update($request->validated());
        return HelperController::modelUpdateSuccessfulMessage($printer);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Printer $printer)
    {
        $printer->delete();
        return HelperController::modelDeleteSucessfulMessage($printer);
    }
}
