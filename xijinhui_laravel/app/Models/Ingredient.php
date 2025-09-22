<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Pinyin;


class Ingredient extends Model
{
    use HasFactory;

    protected $fillable = [
        "english_name",
        'chinese_name',
        'khmer_name',
        'quantity',
        'unit_capacity',
        'un_package',
        'chinese_keyword',
    ];

    protected static function booted(): void
    {
        static::creating(function (Ingredient $ingredient) {
            $ingredient->chinese_keyword = collect(explode(' ', Pinyin::sentence($ingredient->chinese_name, 'none')))->map(fn($it) => $it[0])->join('');
        });
    }

    public function foodIngredients(): \Illuminate\Database\Eloquent\Relations\HasMany
    {
        return $this->hasMany(FoodIngredient::class);
    }

    // public function warehouses(): \Illuminate\Database\Eloquent\Relations\HasMany
    // {
    //     return $this->hasMany(Warehouse::class);
    // }

    public function transactions(): \Illuminate\Database\Eloquent\Relations\HasMany
    {
        return $this->hasMany(IngredientTransaction::class);
    }
}
