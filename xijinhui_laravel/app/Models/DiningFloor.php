<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class DiningFloor extends Model
{
    use HasFactory;
    protected $table = 'dining_floors';
    protected $fillable = [
        'floor_code',
        'english_name',
        'chinese_name',
        'khmer_name',
        'remark',
        'is_enable',
        'deleted_at',
        'created_at',
        'updated_at',
    ];
    protected $hidden = [
        'created_at',
        'updated_at',
        'deleted_at'
    ];
    protected $casts = [
        'is_enable' => 'boolean'
    ];

    public function dining_table()
    {
        return $this->hasMany(DiningTable::class);
    }
}
