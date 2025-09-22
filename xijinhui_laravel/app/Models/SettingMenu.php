<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Kalnoy\Nestedset\NodeTrait;

class SettingMenu extends Model
{
    use HasFactory, NodeTrait;

    protected $fillable = [
        'english_name',
        'chinese_name',
        'khmer_name',
        'icons_path',
        'route_path',
        'parent_id',
        'sort',
        'type',
        'is_system',
        'component',
    ];
}
