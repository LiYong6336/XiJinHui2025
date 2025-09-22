<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class AnimalPart extends Model
{
    use HasFactory;

    protected $fillable = [
        'english_name',
        'chinese_name',
        'khmer_name',
        'type',
    ];
}
