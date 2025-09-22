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
        Schema::create('dining_floors', function (Blueprint $table) {
            $table->id();
            $table->string('floor_code',10)->unique()->comment('楼层编号');
            $table->string('english_name',50)->nullable()->comment('英文名字');
            $table->string('chinese_name',50)->nullable()->comment('中文名字');
            $table->string('khmer_name',50)->nullable()->comment('柬文名字');
            $table->string('remark',100)->nullable()->comment('备注');
            $table->string('description',100)->nullable()->comment('描述');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('dining_floors');
    }
};
