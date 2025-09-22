<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('setting_menu_roles', function (Blueprint $table) {
            $table->foreignId('setting_menu_id')->comment('菜单ID')->constrained('setting_menus')->onDelete('cascade');
            $table->foreignId('role_id')->comment('角色ID')->constrained('roles')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('setting_menu_roles');
    }
};
