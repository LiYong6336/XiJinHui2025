<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\Hash;
use Faker\Generator;
use Illuminate\Support\Facades\File;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {

        $hostname = env("APP_NAME", "localhost");

        $json = File::get("database/data/user.json");
        $user = json_decode($json);

        foreach ($user as $key => $value) {
            $user = User::firstOrCreate([
                'name' => $value->name,
                'username' => $value->name,
                'phone' => random_int(100000000, 999999999),
                'email' => $value->name . '@' . $hostname . '.com',
                'password' => Hash::make($value->password),
                'user_locale' => $value->user_locale ?? 'en',
                'is_admin' => $value->is_admin,
                'is_superadmin' => $value->is_superadmin,
            ]);
            $user->roles()->attach($value->role_id);
        }
    }
}
