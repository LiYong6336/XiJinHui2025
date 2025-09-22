<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\SoftDeletes;
use Illuminate\Support\Facades\Storage;

class FoodDish extends Model
{
    use HasFactory, SoftDeletes;

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

        'is_enable',
        'is_sale',
        'is_mixable',
        'is_cocktail',

        'unit_capacity_type',
        'unit_capacity',
        'un_package',
    ];
    protected $hidden = [
        'created_at',
        'updated_at',
        'deleted_at'
    ];
    protected $casts = [
        'is_enable' => 'boolean',
        'can_change_price' => 'boolean',
        'is_cocktail' => 'boolean',
        'is_sale' => 'boolean',
        'is_mixable' => 'boolean',
    ];

    protected $appends = ['food_photo_url'];

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

    public function ingredients()
    {
        return $this->hasMany(FoodIngredient::class, 'ingredient_id');
    }

    // public function warehouseTransactions()
    // {
    //     return $this->hasMany(WarehouseTransaction::class, 'item_id');
    // }

    public function animalParts()
    {
        return $this->hasMany(AnimalPart::class);
    }

    public function saleDetails()
    {
        return $this->hasMany(SaleDetail::class);
    }

    public function saleDetailIngredients()
    {
        return $this->hasMany(SaleDetailIngredient::class, 'ingredient_id');
    }

    public function warehouse()
    {
        return $this->hasOne(Warehouse::class, 'item_id');
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

