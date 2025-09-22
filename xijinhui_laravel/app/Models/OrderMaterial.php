<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class OrderMaterial extends Model
{
    use HasFactory;

    protected $table = 'order_materials';
    protected $fillable = [
        'english_name',
        'chinese_name',
        'khmer_name',
        'qty',
    ];
    protected $hidden = [
        'created_at',
        'updated_at',
    ];

}
