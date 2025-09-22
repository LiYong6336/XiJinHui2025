<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Category extends Model
{
    use HasFactory;

    protected $table = 'categories';
    protected $fillable = [
        'category_code',
        'english_name',
        'chinese_name',
        'khmer_name',
        'remark',
        'category_photo',
        'printer_id',
        'is_animal_part',
        'deleted_at',
        'created_at',
        'updated_at',
    ];

    protected $hidden = [
        'created_at',
        'deleted_at',
        'updated_at',
    ];
    protected $casts = [
        'created_at' => 'datetime',
        'updated_at' => 'datetime',
        'is_animal_part' => 'boolean',
        'is_drink' => 'boolean',
    ];

    public function products()
    {
        return $this->hasMany(FoodDish::class, 'category_id', 'id');
    }

    public function parent()
    {
        return $this->belongsTo(Category::class, 'parent_id', 'id');
    }

    public function children()
    {
        return $this->hasMany(Category::class, 'parent_id', 'id');
    }

    public function printer()
    {
        return $this->belongsTo(Printer::class, 'printer_id', 'id');
    }
}
