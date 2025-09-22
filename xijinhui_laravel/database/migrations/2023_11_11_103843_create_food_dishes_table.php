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
        Schema::create('food_dishes', function (Blueprint $table) {
            $table->id();
            $table->foreignId('category_id')->default(1)->comment('分类id')
                ->constrained('categories')->onDelete('cascade');
            $table->string('food_code', 10)->nullable()->comment('菜品编号');
            $table->string('english_name')->nullable()->comment('英文名字');
            $table->string('chinese_name')->nullable()->comment('中文名字');
            $table->string('khmer_name')->nullable()->comment('泰语名字');
            $table->string('description', 25)->nullable()->comment('描述');
            $table->decimal('food_price', 8, 2)->default(0)->comment('价格');
            $table->string('remark', 50)->nullable()->comment('备注');
            $table->string('food_photo')->nullable()->comment('图片');
            $table->string('english_keyword', 25)->nullable()->comment('英文名字关键字');
            $table->string('chinese_keyword')->nullable()->comment('中文名字关键字');
            $table->string('thai_keyword', 25)->nullable()->comment('泰文名字关键字');
            $table->integer('display_order')->default(0)->comment('显示顺序');
            $table->boolean('is_enable')->default(true)->comment('是否上线');
            $table->boolean('can_change_price')->default(false)->comment('是否上线');

            $table->unique(['english_name', 'chinese_name', 'khmer_name'], 'food_dishes_unique');
            $table->softDeletes();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('food_dishes');
    }
};
