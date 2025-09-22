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
        Schema::create('animal_parts', function (Blueprint $table) {
            $table->id();
            $table->foreignId('food_dish_id')->nullable()->constrained()->cascadeOnDelete();
            $table->string('english_name')->nullable();
            $table->string('chinese_name')->nullable();
            $table->string('khmer_name')->nullable();
            $table->string('type')->default('h');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('animal_parts');
    }
};
