<?php

namespace Database\Seeders;

use App\Models\DiningFloor;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class DiningFloorSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //DiningFloor::truncate();

        $json = File::get("database/data/floor.json");
        $diningFloor = json_decode($json);

        foreach ($diningFloor as $key => $value) {
            DiningFloor::firstOrCreate([
                "floor_code" => $value->floor_code,
                "english_name" => $value->english_name,
                "chinese_name" => $value->english_name,
                "khmer_name" => $value->english_name,
            ]);
        }
    }
}
