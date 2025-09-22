<?php

namespace Database\Seeders;

use App\Models\Ingredient;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\File;

class IngredientSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $json = File::get("database/data/ingredients.json");
        $incredients = json_decode($json);

        foreach ($incredients as $key => $value) {
            $unPackage = $value->un_package ? $value->un_package : 1;
            $unitCapacity = $value->unit_capacity ? $value->unit_capacity : 1000;

            Ingredient::firstOrCreate([
                'english_name' => $value->english_name,
                'chinese_name' => $value->chinese_name,
                'khmer_name' => $value->khmer_name,
                'un_package' => $unPackage,
                'unit_capacity' => $unitCapacity,
            ]);
        }
    }
}
