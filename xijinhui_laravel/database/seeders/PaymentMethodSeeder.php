<?php

namespace Database\Seeders;

use App\Models\PaymentMethod;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use File;

class PaymentMethodSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        //PaymentMethod::truncate();

        $json = File::get("database/data/payment_method.json");
        $paymentMethod = json_decode($json);

        foreach ($paymentMethod as $key => $value) {
            PaymentMethod::firstOrCreate([
                "payment_code" => $value->payment_code,
                "english_name" => $value->english_name,
                "chinese_name" => $value->chinese_name,
                "khmer_name" => $value->khmer_name,
                "payment_url" => $value->payment_url
            ]);
        }
    }
}
