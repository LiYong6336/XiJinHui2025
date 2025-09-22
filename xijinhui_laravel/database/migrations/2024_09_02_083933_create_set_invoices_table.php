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
        Schema::create('set_invoices', function (Blueprint $table) {
            $table->id();
            $table->date('invoice_date')->unique();
            $table->integer('invoice_start');
            $table->integer('invoice_count');
            $table->integer('invoice_end');

            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('set_invoices');
    }
};
