<?php

namespace Database\Seeders;

use App\Models\Category;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class CategorySeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $json = File::get("database/data/category.json");
        $category = json_decode($json);

        foreach ($category as $key => $value) {
            Category::firstOrCreate([
                "category_code" => $value->category_code,
                "english_name" => $value->english_name,
                "chinese_name" => $value->chinese_name,
                "khmer_name" => $value->khmer_name,
                "printer_id" => $value->printer_id,
                "is_animal_part" => $value->is_animal_part ?? false,
                "is_drink" => $value->is_drink ?? false,
            ]);
        }
    }
}
