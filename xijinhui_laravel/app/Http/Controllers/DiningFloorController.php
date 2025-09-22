<?php

namespace App\Http\Controllers;

use App\Models\DiningFloor;
use App\Http\Requests\StoreDiningFloorRequest;
use App\Http\Requests\UpdateDiningFloorRequest;
use Illuminate\Support\Facades\Log;

class DiningFloorController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //
        $dinings = DiningFloor::all();
        return HelperController::modelGetAllSuccessfuleMessage($dinings, 'Dining Floor');
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
    public function store(StoreDiningFloorRequest $request)
    {
        //
        $dinings =  DiningFloor::create([
            'floor_code' => $request->floor_code,
            'english_name' => $request->floor_code,
            'chinese_name' => $request->chinese_name,
            'khmer_name' => $request->khmer_name,
            'remark' => $request->remark,
            'description' => $request->description,
        ]);

        return HelperController::modelCretedSuccessfuleMessage($dinings, 'Dining Floor');
    }

    /**
     * Display the specified resource.
     */
    public function show(DiningFloor $diningFloor)
    {
        $diningFloor = DiningFloor::find($diningFloor->id);
        if (is_null($diningFloor)) {
            return HelperController::modelOperationErrorMessage('Dining Floor Not Found');
        }
        return HelperController::modelGetSingleSuccessfulMessage($diningFloor, 'Dining Floor');
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(DiningFloor $diningFloor)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateDiningFloorRequest $request, DiningFloor $diningFloor)
    {

        $diningFloor->floor_code = $request->floor_code;
        $diningFloor->english_name = $request->floor_code;
        $diningFloor->chinese_name = $request->chinese_name;
        $diningFloor->khmer_name = $request->khmer_name;
        $diningFloor->remark = $request->remark;
        $diningFloor->description = $request->description;
        $diningFloor->save();

        return HelperController::modelUpdateSuccessfulMessage($diningFloor, 'Dining Floor');
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(DiningFloor $diningFloor)
    {

        if ($diningFloor) {
            Log::info(auth()->user() . 'Delete' . $diningFloor);
            $diningFloor->delete();
            return HelperController::modelDeleteSucessfulMessage($diningFloor, 'Dining Floor');
        } else {
            return HelperController::modelOperationErrorMessage('Not Found');
        }
    }
}
