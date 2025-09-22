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
        Schema::create('table_bookings', function (Blueprint $table) {
            $table->id();
            $table->foreignId('dining_table_id')->constrained('dining_tables')->onDelete('cascade');
            $table->timestamp('using_date',)->comment('使用时间');
            $table->string('customer_name',50)->comment('名字');
            $table->string('phone_number',20)->comment('电话号码');
            $table->enum('speak_language', ['ENGLISH', 'CHINESE', 'KHMER', 'OTHER'])
                ->default('KHMER')->comment('客人使用语言');
            $table->tinyInteger('person_count')->default(0)->comment('人数');
            $table->enum('reason',['CONSUME','COUPLE','FAMILY','FRIEND','OTHER'])
                ->default('CONSUME')->comment('备注');
            $table->string('remark',100)->nullable()->comment('备注');
            $table->unsignedInteger('status')->default(1)->comment('0:结束；1:已定;2:取消');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('table_bookings');
    }
};
