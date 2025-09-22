<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration {
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('printers', function (Blueprint $table) {
            $table->id();
            $table->string('printer_brand', 50)->nullable()->comment('打印机品牌');
            $table->string('deviceName', 50)->comment('设备名字');
            $table->ipAddress('printer_ip_address')->unique()->comment('IP 地址');
            $table->string('port')->default('9100')->comment('端口');
            $table->boolean('isBle')->default(0)->comment('是否蓝牙打印机');
            $table->enum('printer_type', ['network', 'bluetooth', 'usb'])->default('network')->comment('打印机类型');
            $table->string('print_location', 50)->nullable()->comment('打印机位置');
            $table->string('remark', 100)->nullable()->comment('备注');
            $table->string('description', 100)->nullable()->comment('描述');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('printers');
    }
};
