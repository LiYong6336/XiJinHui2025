<?php

namespace Database\Seeders;

// use Illuminate\Database\Console\Seeds\WithoutModelEvents;

use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     */
    public function run(): void
    {
        // \App\Models\User::factory(10)->create();

        $this->call([
            AnimalPartSeeder::class,
            IngredientSeeder::class,
            ExchangeRateSeeder::class,
            RoleSeeder::class,
            UserSeeder::class,
            PrinterSeeder::class,
            CategorySeeder::class,
            FoodDishSeeder::class,
            FoodDishDetailSeeder::class,
            DiningFloorSeeder::class,
            DiningTableSeeder::class,
            MoneyPaperTypeSeeder::class,
            PaymentMethodSeeder::class,
            SettingMenuSeeder::class,
        ]);
    }
}
