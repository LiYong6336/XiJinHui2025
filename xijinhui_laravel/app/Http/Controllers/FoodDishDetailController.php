<?php

namespace App\Http\Controllers;

use App\Models\FoodDishDetail;
use App\Http\Requests\StoreFoodDishDetailRequest;
use App\Http\Requests\UpdateFoodDishDetailRequest;
use App\Models\FoodDish;

class FoodDishDetailController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(FoodDish $foodDish)
    {
        return HelperController::modelGetAllSuccessfuleMessage($foodDish->foodDishDetails()->get());
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
    public function store(StoreFoodDishDetailRequest $request, FoodDish $foodDish)
    {
        $foodDishDetail = $foodDish->foodDishDetails()->create($request->validated());

        return HelperController::modelCretedSuccessfuleMessage($foodDishDetail);
    }

    /**
     * Display the specified resource.
     */
    public function show(FoodDishDetail $foodDishDetail)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(FoodDishDetail $foodDishDetail)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateFoodDishDetailRequest $request, FoodDish $foodDish, FoodDishDetail $foodDishDetail)
    {
        $foodDishDetail->update($request->validated());
        return HelperController::modelUpdateSuccessfulMessage($foodDishDetail->refresh());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(FoodDish $foodDish, FoodDishDetail $foodDishDetail)
    {
        $foodDishDetail->delete();

        return HelperController::modelDeleteSucessfulMessage($foodDishDetail);
    }
}
