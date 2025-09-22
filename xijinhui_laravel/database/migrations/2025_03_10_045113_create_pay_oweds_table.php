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
        Schema::create('pay_oweds', function (Blueprint $table) {
            $table->id();
            $table->foreignUuid('sale_table_id')->constrained()->cascadeOnDelete();
            $table->timestamp('paid_at')->nullable();
            $table->decimal('amount', 14, 4)->default(0);
            $table->foreignId('user_id')->nullable()->constrained()->nullOnDelete();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('pay_oweds');
    }
};
