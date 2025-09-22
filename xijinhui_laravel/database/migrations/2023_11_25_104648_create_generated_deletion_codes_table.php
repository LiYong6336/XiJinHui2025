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
        Schema::create('generated_deletion_codes', function (Blueprint $table) {
            $table->id();
            $table->string('code', 191)->comment('删除码');
            $table->string('using_from_db_function')->nullable()->comment('从那个表使用');
            $table->integer('user_id')->nullable()->comment('使用者');
            $table->dateTime('used_date')->nullable()->comment('使用时间');
            $table->json('sale_detail_json')->comment('菜品json');
            $table->softDeletes();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('generated_deletion_codes');
    }
};
