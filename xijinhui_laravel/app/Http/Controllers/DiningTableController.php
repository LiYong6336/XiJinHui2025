<?php

namespace App\Http\Controllers;

use App\Models\DiningTable;
use App\Http\Requests\StoreDiningTableRequest;
use App\Http\Requests\UpdateDiningTableRequest;
use App\Models\SaleTable;
use Illuminate\Support\Facades\Log;

class DiningTableController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $tables = DiningTable::when(request('is_enable'), function ($query) {
            $query->where('is_enable', request('is_enable'));
        })->with('dining_floor')->get();
        //['id', 'status_code', 'dining_table_id', 'sale_date', 'person_count']
        $sale_table = SaleTable::where('status_code', 1)->get();
        $result['dining'] = $tables;
        $result['busyTable'] = $sale_table;
        return HelperController::modelGetAllSuccessfuleMessage($result);
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
    public function store(StoreDiningTableRequest $request)
    {
        $input = $request->all();
        try {
            $dinigTable = new DiningTable();
            $dinigTable->fill($request->all());
            $dinigTable->save();
            //$dinigTable = DiningTable::create([
            //                $input->dining_table_code
            // $input->english_name=
            // $input->chinese_name
            // $input->khmer_name
            // $input->remark
            // $input->person_count
            // $input->tax_percentage
            // $input->tax_fixPrice
            // $input->room_service_percentage
            // $input->room_service_fixPrice
            // $input->is_broken
            // $input->is_enable
            // $input->calculation_type
            // $input->flag_status
            // $input->dining_floor_id


            //]);
            //$dinigTable->save();

            //return ['data' => $dinigTable];

            return HelperController::modelCretedSuccessfuleMessage($dinigTable->refresh());
        } catch (\Exception $e) {
            return HelperController::modelOperationErrorMessage($e);
        }
    }

    /**
     * Display the specified resource.
     */
    public function show($id)
    {
        $diningTable = DiningTable::find($id);

        if (is_null($diningTable)) {
            return HelperController::modelOperationErrorMessage('MODEL NOT FOUND');
        }
        return HelperController::modelGetSingleSuccessfulMessage($diningTable);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(DiningTable $diningTable)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateDiningTableRequest $request, DiningTable $diningTable)
    {
        $input = $request->all();

        $diningTable->dining_table_code = $input['dining_table_code'];
        $diningTable->english_name = $input['english_name'];
        $diningTable->chinese_name = $input['chinese_name'];
        $diningTable->khmer_name = $input['khmer_name'];
        $diningTable->remark = $input['remark'];
        $diningTable->person_count = $input['person_count'];
        $diningTable->tax_percentage = $input['tax_percentage'];
        $diningTable->tax_fixPrice = $input['tax_fixPrice'];
        $diningTable->room_service_percentage = $input['room_service_percentage'];
        $diningTable->room_service_fixPrice = $input['room_service_fixPrice'];
        $diningTable->is_broken = $input['is_broken'];
        $diningTable->is_enable = $input['is_enable'];
        $diningTable->flag_status = $input['flag_status'] ?? 1;
        $diningTable->dining_floor_id = $input['dining_floor_id'] ?? 1;
        $diningTable->save();
        return HelperController::modelUpdateSuccessfulMessage($diningTable);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy($id)
    {
        $diningTable = DiningTable::find($id);
        if ($diningTable) {
            Log::info(auth()->user() . 'Delete' . $diningTable);
            $diningTable->delete();
            return HelperController::modelDeleteSucessfulMessage($diningTable);
        } else {
            return HelperController::modelOperationErrorMessage('Not Found');
        }
    }
}
