<?php

namespace Database\Seeders;

use App\Models\ExchangeRate;
use Carbon\Carbon;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class ExchangeRateSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        ExchangeRate::truncate();

        ExchangeRate::create([
            'exchange_date' => Carbon::make('2022-05-06'),
            'rate_standard' => '4100',
            'rate_returned' => '4000',
            'rate_nssf' => '4050',
            'rate_taxation' => '4060',
        ]);
    }
}
