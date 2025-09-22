<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class MoneyPaperType extends Model
{
    use HasFactory;

    protected $table = 'money_paper_types';

    protected $fillable = [
        'english_name',
        'chinese_name',
        'khmer_name',
        'paper_value',
        'paper_code',
        'paper_country',
        'paper_status',
        'paper_remarks',
        'created_at',
        'updated_at',
    ];
    protected $hidden = [
        'created_at',
        'updated_at',

    ];
    protected $casts = [
        'created_at' => 'datetime',
        'updated_at' => 'datetime',
    ];

}
