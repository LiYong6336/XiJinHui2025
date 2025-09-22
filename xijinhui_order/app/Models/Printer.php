<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Printer extends Model
{
    use HasFactory;

    protected $table = 'printers';
    protected $fillable = [
        'printer_brand',
        'deviceName',
        'printer_ip_address',
        'port',
        'isBle',
        'printer_type',
        'print_location',
        'remark',
        'description',
        'created_at',
        'updated_at',
    ];
    protected $hidden = [
        'created_at',
        'updated_at',

    ];

    protected $casts = [
        'isBle'=>'boolean',
        'created_at' => 'datetime',
        'updated_at' => 'datetime',
    ];
}
