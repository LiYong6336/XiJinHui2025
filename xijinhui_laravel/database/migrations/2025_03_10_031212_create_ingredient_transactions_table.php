<?php

use App\Models\Stock;
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
        Schema::create('ingredient_transactions', function (Blueprint $table) {
            $table->id();
            $table->decimal('quantity', 14, 4)->default(0);
            $table->decimal('before_quantity', 14, 4)->default(0);
            $table->decimal('after_quantity', 14, 4)->default(0);
            $table->enum('operation', Stock::Operations);
            $table->date('transaction_date');
            $table->timestamps();

            $table->foreignId('ingredient_id')->constrained()->cascadeOnDelete();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('ingredient_transactions');
    }
};
