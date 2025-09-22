<?php

use App\Models\FoodDish;
use Illuminate\Support\Facades\Route;
use Overtrue\LaravelPinyin\Facades\Pinyin;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', function () {
    //return redirect('https://www.khmernokor.com');
    $fds = FoodDish::all();
    foreach ($fds as $f) {
        $f->chinese_keyword = collect(Pinyin::convert($f->chinese_name))->map(fn($it) => $it[0])->join('');
        $f->save();
    }
});
