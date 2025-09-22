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
        Schema::create('sale_details', function (Blueprint $table) {
            $table->id();
            $table->foreignUuid('sale_table_id')->constrained('sale_tables')->cascadeOnDelete();
            $table->string('description')->nullable()->comment('描述');
            $table->string('remark')->nullable()->comment('备注');
            $table->decimal('qty')->default(0.0)->comment('数量');
            $table->decimal('old_qty')->default(0.0)->comment('数量');
            $table->decimal('food_price')->default(0.0)->comment('菜品原始金额');
            $table->decimal('total_amount')->default(0)->comment('合计金额');
            $table->decimal('discount_percentage')->default(0)->comment('打折百分比 0-100%');
            $table->decimal('discount_amount')->default(0)->comment('打折金额');
            $table->decimal('total_amount_after_discount')->default(0)->comment('打折后金额');
            $table->foreignId('food_dish_id')->constrained()->cascadeOnDelete();
            $table->foreignId('food_dish_detail_id')->nullable()->constrained()->nullOnDelete();
            $table->json('food_dish_json')->comment('菜品json');
            $table->json('food_dish_detail_json')->nullable();
            $table->timestamps();
            //$table->foreign('sale_table_id')->references('id')->on('sale_tables')->cascadeOnDelete();
            //->constrained('sale_tables')->onDelete('cascade')
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('sale_details');
    }
};
