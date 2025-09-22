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
        Schema::create('setting_menus', function (Blueprint $table) {
            $table->id();
            $table->string('english_name', 50)->nullable()->comment('英文名字');
            $table->string('chinese_name', 50)->nullable()->comment('中文名字');
            $table->string('khmer_name', 50)->nullable()->comment('柬文名字');
            $table->string('icons_path')->nullable()->comment('图标路径');
            $table->string('route_path')->nullable()->comment('前端路径');
            $table->tinyInteger('sort')->default('1')->comment('排序');
            $table->tinyInteger('type')->default('1')->comment('1:菜单 2:按钮');
            $table->tinyInteger('is_system')->default('0')->comment('1:菜单 2:按钮');
            $table->string('component', 50)->nullable()->comment('1:菜单 2:按钮');
            $table->unique(['english_name', 'chinese_name', 'khmer_name'], 'unique_setting_menu');
            //$table->foreignId('brand_name_id')->references('brand_names')->onDelete('cascade');

            $table->nestedSet();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('setting_menus');
    }
};
