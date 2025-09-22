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
        Schema::create('dining_tables', function (Blueprint $table) {
            $table->id();
            $table->string('dining_table_code',10)->unique()->comment('桌子编号');
            $table->string('english_name',50)->nullable()->comment('英文名字');
            $table->string('chinese_name',50)->nullable()->comment('中文名字');
            $table->string('khmer_name',50)->nullable()->comment('柬文名字');
            $table->string('remark',100)->nullable()->comment('备注');
            $table->integer('person_count')->default(0)->comment('人数');
            $table->decimal('tax_percentage')->default(0)->comment('增值税售的百分比');
            $table->decimal('tax_fixPrice')->default(0)->comment('增值税固定费用');
            $table->decimal('room_service_percentage')->default(0)->comment('房费销售的百分比');
            $table->decimal('room_service_fixPrice')->default(0)->comment('房费固定费用');
            $table->boolean('is_broken')->default(false)->comment('是否损坏，默认否');
            $table->boolean('is_enable')->default(true)->comment('是否开启，默认开启');
            $table->boolean('calculation_type')->default(false)->comment('Default:false，默认否');
            $table->integer('flag_status')->default(0)->comment('状态 1:空闲 2:使用中 3:预定 4:清洁 5:维修');
            $table->timestamps();
            $table->foreignId('dining_floor_id')->constrained('dining_floors')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('dining_tables');
    }
};
