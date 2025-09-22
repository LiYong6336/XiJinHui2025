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
        Schema::create('food_dish_details', function (Blueprint $table) {
            $table->id();
            $table->string('english_name')->nullable();
            $table->string('chinese_name')->nullable();
            $table->string('khmer_name')->nullable();
            $table->decimal('price', 18, 2)->default(0);
            $table->foreignId('food_dish_id')->constrained()->cascadeOnDelete();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('food_dish_details');
    }
};
