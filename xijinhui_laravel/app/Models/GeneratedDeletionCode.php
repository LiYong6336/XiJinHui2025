<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\SoftDeletes;

class GeneratedDeletionCode extends Model
{
    use HasFactory, SoftDeletes;

    protected $table = 'generated_deletion_codes';
    protected $fillable = [
        'code',
        'using_from_db_function',
        'sale_detail_json',
        'user_id',
        'used_date',
    ];

}
