<?php

namespace Database\Seeders;

use App\Models\MoneyPaperType;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class MoneyPaperTypeSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        MoneyPaperType::truncate();

        $json = \File::get("database/data/money_paper.json");
        $countries = json_decode($json);

        foreach ($countries as $key => $value) {
            MoneyPaperType::create([
                "english_name" => $value->english_name,
                "chinese_name" => $value->chinese_name,
                "khmer_name" => $value->khmer_name,
                "paper_value" => $value->paper_value,
                "paper_code" => $value->paper_code,
                "paper_country" => $value->paper_country,
                "paper_status" => $value->paper_status,
            ]);
        }
    }
}
