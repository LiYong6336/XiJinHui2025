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
        Schema::create('food_ingredients', function (Blueprint $table) {
            $table->id();
            $table->foreignId('food_dish_id')->constrained()->cascadeOnDelete();
            $table->foreignId('food_dish_detail_id')->nullable()->constrained()->nullOnDelete();
            $table->foreignId('ingredient_id')->constrained()->cascadeOnDelete();
            $table->decimal('usage', 12, 6)->default(0)->comment('Quantity or weight (kg)');
            $table->timestamps();

            $table->unique(['food_dish_id', 'food_dish_detail_id', 'ingredient_id'], 'food_ingr_uniq');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('food_ingredients');
    }
};
