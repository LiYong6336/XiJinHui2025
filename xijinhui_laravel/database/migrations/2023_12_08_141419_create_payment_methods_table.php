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
        Schema::create('payment_methods', function (Blueprint $table) {
            $table->id();
            $table->string('payment_code', 20)->unique()->comment('代码');
            $table->string('english_name', 100)->nullable()->comment('英文名字');
            $table->string('chinese_name', 100)->nullable()->comment('中文名字');
            $table->string('khmer_name', 100)->nullable()->comment('泰文名字');
            $table->string('payment_url', 191)->nullable()->comment('链接');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('payment_methods');
    }
};
