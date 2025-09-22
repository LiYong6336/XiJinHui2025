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
        Schema::create('categories', function (Blueprint $table) {
            $table->id();
            $table->string('category_code', 10)->unique()->comment('编号');
            $table->string('english_name', 25)->nullable()->comment('英文名字');
            $table->string('chinese_name', 25)->nullable()->comment('中文名字');
            $table->string('khmer_name', 25)->nullable()->comment('柬文名字');
            $table->string('remark', 50)->nullable()->comment('备注');
            $table->string('category_photo')->nullable()->comment('图片');
            $table->boolean('is_animal_part')->default(false);
            $table->boolean('is_drink')->default(false);
            $table->foreignId('printer_id')->nullable()->constrained('printers')->onDelete('cascade');
            // $table->foreignId('brand_name_id')->references('brand_names')->onDelete('cascade');
            $table->softDeletes();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('categories');
    }
};
