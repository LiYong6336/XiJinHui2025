<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class CustomerTopup extends Model
{
    use HasFactory;

    protected $fillable = [
        'before_balance',
        'topup_amount',
        'after_balance',
        'customer_id',
        'user_id',
    ];

    public function customer()
    {
        return $this->belongsTo(Customer::class);
    }
}
