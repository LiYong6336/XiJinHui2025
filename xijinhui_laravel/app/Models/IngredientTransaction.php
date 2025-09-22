<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class IngredientTransaction extends Model
{
    use HasFactory;

    protected $fillable = [
        'before_quantity',
        'after_quantity',
        'quantity',
        'operation',
        'transaction_date',
        'item_id',
    ];

    protected $appends = [
        'quantity',
    ];

    public function getQuantityAttribute()
    {
        return $this->quantity();
    }

    public function quantity()
    {
        if ($this->operation == Stock::ADDED) {
            return $this->after_quantity - $this->before_quantity;
        }
        return $this->before_quantity - $this->after_quantity;
    }
}
