<?php

namespace Database\Seeders;

use App\Models\FoodDish;
use Illuminate\Database\Seeder;
use File;

class FoodDishSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //$pinyin = new Pinyin(); // 默认
        //FoodDish::truncate();

        $json = File::get("database/data/food_dish.json");
        $food_dish = json_decode($json, true);

        foreach ($food_dish as $key => $value) {
            unset($value['deleted_at']);
            FoodDish::firstOrCreate($value);
            // FoodDish::firstOrCreate([
            //     //"id"=>$value->id,
            //     "category_id" => $value->category_id,
            //     "food_code" => $value->food_code,
            //     "english_name" => $value->english_name,
            //     "chinese_name" => $value->chinese_name,
            //     "khmer_name" => $value->khmer_name,
            //     "food_price" => $value->food_price,
            //     //                "english_keyword" => HelperController::getFirstLetterFromEnglish($value->english_name??' '),
            //     //                "chinese_keyword" => strtoupper($pinyin->abbr($value->chinese_name, ' ')??'零'),
            // ]);
        }
    }
}
