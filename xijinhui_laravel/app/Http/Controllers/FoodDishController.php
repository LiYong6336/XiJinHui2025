<?php

namespace App\Http\Controllers;

use App\Models\Category;
use App\Models\FoodDish;
use App\Http\Requests\StoreFoodDishRequest;
use App\Http\Requests\UpdateFoodDishRequest;
use App\Models\FoodDishDetail;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Storage;
use Intervention\Image\ImageManager;
use Intervention\Image\Drivers\Gd\Driver;

class FoodDishController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(Request $request)
    {
        $food_dish = new FoodDish();
        if ($request->has("is_enable")) {
            $food_dish = $food_dish->where('is_enable', 1);
        }
        if ($request->get("ignore_ids")) {
            $arrIds = explode(',', $request->get('ignore_ids', ''));
            $food_dish = $food_dish->whereNotIn('id', $arrIds);
        }
        if ($request->get('search')) {
            $search = $request->get('search');
            $food_dish = $food_dish->where('english_name', 'LIKE', "$search%")
                ->orWhere('chinese_name', 'LIKE', "%$search%")
                ->orWhere('khmer_name', 'LIKE', "%$search%")
                ->orWhere('english_keyword', 'LIKE', "%$search%")
                //->orWhere('khmer_keyword', 'LIKE', "$search%")
                ->orWhere('chinese_keyword', 'LIKE', "%$search%")
                ->orWhere('food_code', $search);
        }

        if ($request->has('is_sale')) {
            $is_sale = $request->boolean('is_sale');
            $food_dish = $food_dish->where('is_sale', $is_sale);
        }
        if ($request->has('is_mixable')) {
            $is_mixable = $request->boolean('is_mixable');
            $food_dish = $food_dish->where('is_mixable', $is_mixable);
        }

        if ($request->has("order_by") && $request->has("order_dir")) {
            $food_dish = $food_dish->orderBy($request->get('order_by'), $request->get('order_dir'));
        } else {
            $food_dish = $food_dish->orderBy('display_order')
                ->orderBy('created_at', 'desc');
        }


        $food_dish = $food_dish->with(
            'category',
            'category.printer',
            'foodDishDetails',
            'foodIngredients.ingredient',
            'foodDishDetails.foodIngredients',
            //'animalParts'
        )
            ->get();

        if ($request->has('with_categories')) {
            $category = Category::with('printer')->get();
            $result['food_dish'] = $food_dish;
            $result['categories'] = $category;
        } else {
            $result = $food_dish;
        }

        return HelperController::modelGetAllSuccessfuleMessage($result);
    }
    public function getOnlyFoodDish()
    {
        $food_dish = FoodDish::orderBy('display_order')->paginate(10);

        return response($food_dish);
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
    public function store(StoreFoodDishRequest $request)
    {
        $img = null;
        if ($request->hasFile('food_photo_upload')) {
            $file = $request->file('food_photo_upload');
            $fileName = ($request->english_name ? $request->english_name : $request->chinese_name); // . '.' . $file->getClientOriginalExtension();

            // Resize the image
            $manager = new ImageManager(new Driver());

            // read image from file system
            $image = $manager->read($file);

            // resize image proportionally to 300px width
            $image->scale(width: 300);

            // save modified image in new format
            //$image->toPng()->save('images/foo.png');

            // Store the image in storage/app/public/images
            $img = "food_dish/{$fileName}.png";
            Storage::put($img, (string) $image->toPng());

            //$img = $file->storeAs('food_dish', $fileName);
        }
        $foodDish = FoodDish::create(array_merge($request->validated(), [
            'food_photo' => $img,
        ]));

        return HelperController::modelCretedSuccessfuleMessage($foodDish->refresh());
    }

    /**
     * Display the specified resource.
     */
    public function show(FoodDish $foodDish)
    {
        $foodDish = FoodDish::where('id', $foodDish->id)->first();

        return HelperController::modelGetAllSuccessfuleMessage($foodDish);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(FoodDish $foodDish)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateFoodDishRequest $request, FoodDish $foodDish)
    {
        $img = $foodDish->food_photo;
        if ($request->file('food_photo_upload')) {
            //$img = $request->file('food_photo_upload')->store('food_dish');
            $file = $request->file('food_photo_upload');
            $fileName = ($request->english_name ? $request->english_name : $request->chinese_name); // . '.' . $file->getClientOriginalExtension();


            // Resize the image
            $manager = new ImageManager(new Driver());

            // read image from file system
            $image = $manager->read($file);

            // resize image proportionally to 300px width
            $image->scale(width: 300);

            // save modified image in new format
            //$image->toPng()->save('images/foo.png');

            // Store the image in storage/app/public/images
            $img = "food_dish/{$fileName}.png";
            Storage::put($img, (string) $image->toPng());


            // $img = $file->storeAs('food_dish', $fileName);
        }
        $foodDish->update(array_merge($request->validated(), [
            'food_photo' => $img,
        ]));
        return HelperController::modelUpdateSuccessfulMessage($foodDish->refresh());
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(FoodDish $foodDish)
    {
        $foodDish->delete();
        return HelperController::modelDeleteSucessfulMessage($foodDish);
    }

    public function applyIngredients(Request $request)
    {
        $foodDishIds = $request->food_dish_ids ?? [];
        $foodDishDetailIds = $request->food_dish_detail_ids ?? [];
        $ingredients = $request->ingredients ?? [];
        $ingredients = is_string($ingredients) ? json_decode($ingredients, true) : $ingredients;
        $ingredients = collect($ingredients)->map(function ($item) {
            return is_string($item) ? json_decode($item, true) : $item;
        });
        $ingredient_ids = $ingredients->map(function ($v) {
            return $v['ingredient_id'];
        })->all();

        $foodDishes = FoodDish::whereIn('id', $foodDishIds)->get();
        $foodDishDetails = FoodDishDetail::whereIn('id', $foodDishDetailIds)->get();

        foreach ($foodDishes as $fd) {
            $fd->foodIngredients()->whereNotIn('ingredient_id', $ingredient_ids)->delete();
            foreach ($ingredients as $ing) {
                $ingre = is_string($ing) ? json_decode($ing) : $ing;
                $fd->foodIngredients()->updateOrCreate([
                    'ingredient_id' => $ingre['ingredient_id'],
                ], [
                    'usage' => $ingre['usage']
                ]);
            }
        }

        foreach ($foodDishDetails as $fdt) {
            $fdt->foodIngredients()->whereNotIn('ingredient_id', $ingredient_ids)->delete();
            foreach ($ingredients as $ing) {
                $ingre = is_string($ing) ? json_decode($ing) : $ing;
                $fdt->foodIngredients()->updateOrCreate([
                    'food_dish_id' => $fdt->food_dish_id,
                    'ingredient_id' => $ingre['ingredient_id'] ?? 0,
                ], [
                    'usage' => $ingre['usage'] ?? 0
                ]);
            }
        }

        return HelperController::modelGetAllSuccessfuleMessage(
            FoodDish::with('category', 'category.printer', 'foodDishDetails', 'foodIngredients', 'foodDishDetails.foodIngredients')->get()
        );
    }
}
