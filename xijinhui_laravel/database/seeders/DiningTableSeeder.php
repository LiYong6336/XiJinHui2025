<?php

namespace Database\Seeders;

use App\Models\DiningTable;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class DiningTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //DiningTable::truncate();

        $json = File::get("database/data/dining_table.json");
        $diningTable = json_decode($json);

        foreach ($diningTable as $key => $value) {
            DiningTable::firstOrCreate([
                "id" => $value->id,
                "dining_table_code" => $value->dining_table_code,
                "english_name" => $value->english_name,
                "chinese_name" => $value->chinese_name,
                "khmer_name" => $value->khmer_name,
                "remark" => $value->remark ?? null,
                "is_broken" => $value->is_broken,
                "is_enable" => $value->is_enable,
                "tax_percentage" => ($value->tax_percentage ?? 0) * 100,
                "dining_floor_id" => $value->dining_floor_id,
            ]);
        }
    }
}
