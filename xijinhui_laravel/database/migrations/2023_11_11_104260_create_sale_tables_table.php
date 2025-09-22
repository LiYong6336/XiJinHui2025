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
        Schema::create('sale_tables', function (Blueprint $table) {
            $table->uuid('id')->primary();
            $table->foreignId('dining_table_id')->constrained('dining_tables')->onDelete('cascade');
            $table->foreignId('user_id')->nullable()->constrained('users')->onDelete('cascade')->comment('用户');
            $table->string('sale_order_number')->nullable()->comment('流水编号');
            $table->string('showing_invoice_number')->index()->nullable()->comment('显示票号自动生成');
            $table->string('invoice_number')->unique()->index()->nullable()->comment('结账后自动生成');
            $table->dateTime('sale_date')->index()->comment('销售日期');
            $table->decimal('exchange_rate')->comment('汇率');
            $table->integer('person_count')->default(0)->comment('人数');

            $table->decimal('total_amount')->nullable()->comment('合计金额');
            $table->decimal('discount_percentage')->default(0)->comment('打折百分比');
            $table->decimal('discount_amount')->default(0)->comment('打折金额');
            $table->decimal('tax_amount')->nullable()->comment('增值税金额');
            $table->decimal('room_service_amount')->default(0)->comment('房间服务费用金额');


            $table->decimal('grand_total')->nullable()->comment('总金额');

            $table->decimal('received_dollar')->default(0)->comment('支付美元');
            $table->decimal('received_riel', 14)->default(0)->comment('支付柬币');
            $table->decimal('return_dollars')->default(0)->comment('返回美元');
            $table->decimal('return_riels', 14)->default(0)->comment('返回柬币');
            $table->decimal('balance_dollars')->default(0)->comment('返回柬币');

            $table->string('remark')->nullable()->comment('备注');

            $table->dateTime('finished_dining_date')->nullable()->comment('结算日期');
            $table->integer('take_time')->nullable()->comment('用膳时间-多少秒');


            $table->integer('pre_receipt_print_time')->default(0)->comment('出单次数');
            $table->integer('receipt_print_time')->default(0)->comment('收据打印次数');
            $table->integer('making_status')->default(1)->comment('1:到厨房，2:厨房确认已完成');
            $table->integer('status_code')->default(1)->comment('0:Done-已结账; 1:Busy-等待结账; 2:Booking-订桌, 3:cancel');
            $table->integer('tax_declaration')->default(0)->comment('0:不报税; 1:报税;');
            $table->integer('clearing_user_id')->nullable()->comment('结账人');

            $table->dateTime('clearing_datetime')->nullable()->comment('交班时间');
            $table->boolean('is_secret')->default(true);
            $table->uuid('secret_id')->nullable();
            $table->timestamps();
        });
    }



    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('sale_tables');
    }
};
