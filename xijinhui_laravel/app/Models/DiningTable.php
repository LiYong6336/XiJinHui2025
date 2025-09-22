<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class DiningTable extends Model
{
    use HasFactory;

    protected $table = 'dining_tables';
    protected $fillable = [
        'dining_table_code',
        'english_name',
        'chinese_name',
        'khmer_name',
        'remark',
        'person_count',
        'tax_percentage',
        'tax_fixPrice',
        'room_service_percentage',
        'room_service_fixPrice',
        'is_broken',
        'is_enable',
        'calculation_type',
        'flag_status',
        'dining_floor_id',
    ];
    protected $hidden = [
        //'created_at',
        'updated_at',
        'deleted_at'
    ];
    protected $casts = [
        'is_broken' => 'boolean',
        'is_enable' => 'boolean'
    ];

    public function dining_floor()
    {
        return $this->belongsTo(DiningFloor::class);
    }
}
