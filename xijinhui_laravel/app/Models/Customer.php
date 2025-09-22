<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Customer extends Model
{
    use HasFactory;

    protected $fillable = [
        'code',
        'english_name',
        'chinese_name',
        'khmer_name',
        'phone',
        'address',
        'dob',
        'gender',
        'balance',
    ];

    public function topups()
    {
        return $this->hasMany(CustomerTopup::class);
    }
}
