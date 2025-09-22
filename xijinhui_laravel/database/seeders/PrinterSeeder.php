<?php

namespace Database\Seeders;

use App\Models\Printer;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class PrinterSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        $json = File::get("database/data/printer.json");
        $countries = json_decode($json);

        foreach ($countries as $key => $value) {
            Printer::firstOrCreate([
                "deviceName" => $value->printer_name,
                "printer_brand" => $value->printer_brand,
                "printer_ip_address" => $value->printer_ip_address,

            ]);
        }
    }
}
