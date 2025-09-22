<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Spatie\Permission\Models\Role as ModelRole;

class Role extends ModelRole
{
    use HasFactory;

    public function settingMenus()
    {
        return $this->belongsToMany(SettingMenu::class, 'setting_menu_roles');
    }
}
