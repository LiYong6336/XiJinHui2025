<?php

namespace App\Http\Controllers;

use App\Models\FoodIngredient;
use App\Http\Requests\StoreFoodIngredientRequest;
use App\Http\Requests\UpdateFoodIngredientRequest;
use App\Models\FoodDish;
use App\Models\Ingredient;
use Illuminate\Http\Request;

class FoodIngredientController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(FoodDish $foodDish)
    {
        $foodIngredients = $foodDish->foodIngredients()
            ->with(['foodDish', 'foodDishDetail', 'ingredient']);
        if (request('food_dish_detail_id')) {
            $foodIngredients = $foodIngredients->where('food_dish_detail_id', request('food_dish_detail_id'));
        } else {
            $foodIngredients = $foodIngredients->whereNull('food_dish_detail_id');
        }
        $foodIngredients = $foodIngredients->get();

        return HelperController::modelGetAllSuccessfuleMessage($foodIngredients);
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreFoodIngredientRequest $request, FoodDish $foodDish)
    {
        $check = $foodDish->foodIngredients()
            ->where('food_dish_detail_id', $request->food_dish_detail_id)
            ->where('ingredient_id', $request->ingredient_id)
            ->first();
        if ($check) {
            return response([
                'message' => "Duplicated data",
            ], 422);
        }

        $foodIngredient = $foodDish->foodIngredients()->create([
            'food_dish_detail_id' => $request->food_dish_detail_id,
            'ingredient_id' => $request->ingredient_id,
            'usage' => $request->usage,
        ]);

        return HelperController::modelGetSingleSuccessfulMessage($foodIngredient);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateFoodIngredientRequest $request, FoodDish $foodDish, FoodIngredient $foodIngredient)
    {
        $check = $foodDish->foodIngredients()
            ->where('food_dish_detail_id', $request->food_dish_detail_id)
            ->where('ingredient_id', $request->ingredient_id)
            ->where('id', '<>', $foodIngredient->id)
            ->first();
        if ($check) {
            return response([
                'message' => "Duplicated data",
            ], 422);
        }
        $foodIngredient->update([
            'food_dish_detail_id' => $request->food_dish_detail_id,
            'ingredient_id' => $request->ingredient_id,
            'usage' => $request->usage,
        ]);

        return HelperController::modelGetSingleSuccessfulMessage($foodIngredient);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(FoodDish $foodDish, FoodIngredient $foodIngredient)
    {
        $foodIngredient->delete();

        return response([
            'message' => 'Deleted'
        ]);
    }
}
