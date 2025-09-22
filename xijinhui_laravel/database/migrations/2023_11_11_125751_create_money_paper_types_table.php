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
        Schema::create('money_paper_types', function (Blueprint $table) {
            $table->id();
            $table->string('english_name',25)->nullable()->comment('英文名字');
            $table->string('chinese_name',25)->nullable()->comment('中文名字');
            $table->string('khmer_name',25)->nullable()->comment('柬文名字');
            $table->decimal('paper_value', 10, 0)->comment('纸币面值');
            $table->string('paper_code')->nullable()->comment('紙幣種類代碼 例如: KHR USD');
            $table->string('paper_country')->nullable()->comment('紙幣國家 例如: Cambodia');
            $table->tinyInteger('paper_status')->default(1)->comment('紙幣種類狀態 1:啟用 0:停用');
            $table->string('paper_remarks',50)->nullable()->comment('紙幣種類備註');
            $table->unique(['english_name','chinese_name','khmer_name'], 'money_paper_types_unique');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('money_paper_types');
    }
};
