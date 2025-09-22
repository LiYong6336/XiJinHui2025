<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Stock extends Model
{
    use HasFactory;

    const ADDED = 'add';
    const Operations = ['added', 'confused', 'defective', 'lost', 'take_to_counter'];

    protected $fillable = [
        'invoice_number',
        'operation',
        'price',
        'note',
        'stock_date',
        'user_id',
        'status',
    ];

    protected $casts = [
        'status' => 'boolean'
    ];

    public function user(): \Illuminate\Database\Eloquent\Relations\BelongsTo
    {
        return $this->belongsTo(User::class);
    }

    public function stockItems(): \Illuminate\Database\Eloquent\Relations\HasMany
    {
        return $this->hasMany(StockItem::class);
    }
}
