<?php

namespace App\Http\Controllers;

use App\Models\AnimalPart;
use App\Http\Requests\StoreAnimalPartRequest;
use App\Http\Requests\UpdateAnimalPartRequest;
use App\Models\FoodDish;
use Illuminate\Http\Request;

class AnimalPartController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //return HelperController::modelGetAllSuccessfuleMessage($foodDish->animalParts()->get()->groupBy('type')->all());
        return HelperController::modelGetAllSuccessfuleMessage(AnimalPart::all());
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreAnimalPartRequest $request, FoodDish $foodDish)
    {
        $animalPart = $foodDish->animalParts()->create($request->validated());
        return HelperController::modelGetAllSuccessfuleMessage($foodDish->animalParts()->get());
    }

    /**
     * Display the specified resource.
     */
    public function show(FoodDish $foodDish, AnimalPart $animalPart)
    {
        return HelperController::modelGetSingleSuccessfulMessage($animalPart);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateAnimalPartRequest $request, FoodDish $foodDish, AnimalPart $animalPart)
    {
        $animalPart->update($request->validated());
        return HelperController::modelGetAllSuccessfuleMessage($foodDish->animalParts()->get());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(FoodDish $foodDish, AnimalPart $animalPart)
    {
        $animalPart->delete();
        return response(['success' => true]);
    }

    public function sync(Request $request, FoodDish $foodDish)
    {
        $request->validate([
            'items' => 'array',
            'items.*.id' => 'nullable|integer',
            'items.*.english_name' => 'required|string',
            'items.*.chinese_name' => 'nullable|string',
            'items.*.khmer_name' => 'nullable|string',
            'items.*.type' => 'required|string', // h, w, t, ...
        ]);

        $ids = collect($request->items)->whereNotNull('id')->pluck('id');

        $foodDish->whereNotIn('id', $ids)->delete();

        foreach ($request->get('items', []) as $item) {
            $id = $item['id'] ?? null;
            if ($id) {
                $animalPart = $foodDish->animalParts()->where('id', $id)->first();
                if ($animalPart) {
                    $animalPart->update($item);
                }
            } else {
                $foodDish->animalParts()->create($item);
            }
        }

        return HelperController::modelGetAllSuccessfuleMessage(
            $foodDish->animalParts()->get()->groupBy('type')->all()
        );
    }
}
