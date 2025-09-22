<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class StockItem extends Model
{
    use HasFactory;

    protected $fillable = [
        'item_id',
        'quantity',
        'before_quantity',
        'after_quantity',
        'note',
        'input_date',
        'mfp_date',
        'exp_date',
        'stock_id',
    ];

    public function item()
    {
        return $this->belongsTo(Ingredient::class, 'item_id');
    }
}
