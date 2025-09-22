<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class FoodIngredient extends Model
{
    use HasFactory;

    protected $fillable = [
        'food_dish_id',
        'food_dish_detail_id',
        'ingredient_id',
        'usage',
    ];

    public function foodDish()
    {
        return $this->belongsTo(FoodDish::class);
    }

    public function foodDishDetail()
    {
        return $this->belongsTo(FoodDishDetail::class);
    }

    public function ingredient()
    {
        return $this->belongsTo(Ingredient::class);
    }
}
