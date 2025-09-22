<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\Storage;
use Pinyin;

class FoodDish extends Model
{
    use HasFactory;
    protected $table = 'food_dishes';
    protected $fillable = [
        'category_id',
        'food_code',
        'english_name',
        'chinese_name',
        'khmer_name',
        'description',
        'food_price',
        'remark',
        'food_photo',
        'english_keyword',
        'chinese_keyword',
        'thai_keyword',
        'display_order',
        'is_enable'
    ];
    protected $hidden = [
        'created_at',
        'updated_at',
        'deleted_at'
    ];
    protected $casts = [
        'is_enable' => 'boolean',
        'can_change_price' => 'boolean'
    ];

    protected $appends = ['food_photo_url'];

    protected static function booted(): void
    {
        static::creating(function (FoodDish $foodDish) {
            $foodDish->chinese_keyword = collect(explode(' ', Pinyin::sentence($foodDish->chinese_name, 'none')))->map(fn($it) => ($it[0] ?? ''))->join('');
        });
        static::updating(function (FoodDish $foodDish) {
            $foodDish->chinese_keyword = collect(explode(' ', Pinyin::sentence($foodDish->chinese_name, 'none')))->map(fn($it) => ($it[0] ?? ''))->join('');
        });
    }

    public function category()
    {
        return $this->belongsTo(Category::class);
    }

    public function foodDishDetails()
    {
        return $this->hasMany(FoodDishDetail::class);
    }

    public function foodIngredients()
    {
        return $this->hasMany(FoodIngredient::class);
    }

    public function animalParts()
    {
        return $this->hasMany(AnimalPart::class);
    }

    public function getFoodPhotoUrlAttribute()
    {
        if ($this->food_photo) {
            $url = Storage::url($this->food_photo);
            return $url;
            //return 'https://restaurant.khmernokor.com'. $url;
        }
        return null;
    }
}
