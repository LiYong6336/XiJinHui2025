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
        Schema::create('stocks', function (Blueprint $table) {
            $table->id();
            //$table->enum('unit_type', ['weight', 'qty'])->default('qty');
            //$table->decimal('unit_value', 14, 4)->default(0)->comment('store in kg');
            $table->string('invoice_number')->nullable();
            $table->string('reference')->nullable();
            //$table->decimal('quantity', 14, 4)->default(0);
            $table->enum('operation', Stock::Operations)->default('added');
            //$table->decimal('price')->default(0)->comment('Price per unit|kg');
            $table->string('note')->nullable();
            $table->date('stock_date');
            $table->boolean('status')->default(false);
            $table->timestamps();

            $table->foreignId('user_id')->constrained()->onDelete('cascade');
            //$table->foreignId('ingredient_id')->constrained()->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('stocks');
    }
};
