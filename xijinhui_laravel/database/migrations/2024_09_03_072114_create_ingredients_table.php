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
        Schema::create('ingredients', function (Blueprint $table) {
            $table->id();
            // $table->string('english_name')->nullable();
            // $table->string('chinese_name')->nullable();
            // $table->string('khmer_name')->nullable();
            // $table->enum('unit_type', ['weight', 'qty'])->default('qty');
            // $table->decimal('unit_value', 14, 4)->default(0)->comment('store qty or weight(kg)');
            // $table->decimal('price', 14, 4)->default(0)->comment('price per unit (quantity|weight(kg))');

            $table->string('english_name')->nullable();
            $table->string('chinese_name')->nullable();
            $table->string('khmer_name')->nullable();
            $table->string('chinese_keyword')->nullable();
            //$table->decimal('main_qty', 14, 4)->default(0)->comment('package quantity 10box or 10kg');
            $table->decimal('quantity', 14, 4)->default(0)->comment('un-package quantity 10box * 24can * 330ml or 10kg * 1 * 1000g');
            $table->decimal('un_package', 14, 4)->default(1)->comment('24can or 1');
            $table->decimal('unit_capacity', 14, 4)->default(0)->comment('330ml or 1000g');



            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('ingredients');
    }
};
