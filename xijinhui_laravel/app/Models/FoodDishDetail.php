<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class FoodDishDetail extends Model
{
    use HasFactory;

    protected $fillable = [
        'english_name',
        'chinese_name',
        'khmer_name',
        'price',
        'food_dish_id',
    ];

    public function foodDish()
    {
        return $this->belongsTo(FoodDish::class);
    }

    public function foodIngredients()
    {
        return $this->hasMany(FoodIngredient::class);
    }
}
