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
        Schema::create('exchange_rates', function (Blueprint $table) {
            $table->id();
            $table->date('exchange_date')->unique()->comment('汇率日期');
            $table->integer('exchange_year')->nullable()->comment('年');
            $table->integer('exchange_month')->nullable()->comment('月');
            $table->string('exchange_year_month')->nullable()->comment('yyyy-mm 年月');
            $table->integer('exchange_days')->nullable()->comment('日');
            $table->decimal('rate_standard')->comment('正常汇率');
            $table->decimal('rate_returned')->comment('回购汇率');
            $table->decimal('rate_nssf')->nullable()->comment('社保汇率');
            $table->decimal('rate_taxation')->nullable()->comment('报税汇率');
            $table->softDeletes();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('exchange_rates');
    }
};
