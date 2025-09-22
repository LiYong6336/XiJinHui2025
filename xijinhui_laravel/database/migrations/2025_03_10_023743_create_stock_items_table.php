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
        Schema::create('stock_items', function (Blueprint $table) {
            $table->id();
            $table->decimal('quantity', 14, 4)->default(0);
            $table->decimal('before_quantity', 14, 4)->default(0);
            $table->decimal('after_quantity', 14, 4)->default(0);
            //$table->decimal('price')->default(0);
            $table->string('note')->nullable();
            $table->date('input_date')->nullable();
            $table->date('exp_date')->nullable();
            $table->date('mfp_date')->nullable();
            $table->timestamps();

            $table->foreignId('item_id')->constrained('ingredients')->onDelete('cascade');
            $table->foreignId('stock_id')->constrained()->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('stock_items');
    }
};
