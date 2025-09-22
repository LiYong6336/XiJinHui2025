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
        Schema::create('order_materials', function (Blueprint $table) {
            $table->id();
            $table->string('english_name',50)->nullable()->comment('英文名字');
            $table->string('chinese_name',50)->nullable()->comment('中文名字');
            $table->string('khmer_name',50)->nullable()->comment('柬文名字');
            $table->decimal('qty',8,2)->default(0)->comment('数量');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('order_materials');
    }
};
