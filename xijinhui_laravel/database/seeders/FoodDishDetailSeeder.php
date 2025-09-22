<?php

namespace Database\Seeders;

use App\Models\FoodDishDetail;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class FoodDishDetailSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $json = File::get("database/data/food_dish_details.json");
        $food_dish = json_decode($json);

        foreach ($food_dish as $key => $value) {
            FoodDishDetail::firstOrCreate([
                //"id"=>$value->id,
                "id" => $value->id,
                "english_name" => $value->english_name,
                "chinese_name" => $value->chinese_name,
                "khmer_name" => $value->khmer_name,
                "price" => $value->price,
                "food_dish_id" => $value->food_dish_id,

            ]);
        }
    }
}
