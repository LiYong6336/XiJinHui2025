<?php

namespace Database\Seeders;

use App\Models\AnimalPart;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\File;

class AnimalPartSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $json = File::get("database/data/animal_part.json");
        $category = json_decode($json);

        foreach ($category as $key => $value) {
            AnimalPart::firstOrCreate([
                "english_name" => $value->sub_food_english,
                "chinese_name" => $value->sub_food_chinese,
                "khmer_name" => $value->sub_food_khmer,
                'type' => strtolower($value->sub_food_type),
            ]);
        }
    }
}
