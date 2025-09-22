<?php

namespace App\Console\Commands;

use Illuminate\Console\Command;
use Illuminate\Support\Facades\DB;
use PDO;

class ImportOldSale extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'app:import-old-sale';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Command description';

    /**
     * Execute the console command.
     */
    public function handle()
    {
        $filePath = database_path('data/sale_table.csv');


        $pdo = DB::connection()->getPdo();
        $pdo->setAttribute(PDO::MYSQL_ATTR_LOCAL_INFILE, true);

        $filepath = str_replace('\\', '/', $filePath);

        // custom_id = @col1,
        // name = @col2,
        // email = @col3,
        // company = @col4,
        // city = @col5,
        // country = @col6,
        // birthday = @col7,
        // created_at = NOW(),
        // updated_at = NOW()
        $query = <<<SQL
    LOAD DATA LOCAL INFILE '$filepath'
    INTO TABLE sale_tables
    FIELDS TERMINATED BY ','
    ENCLOSED BY '"'
    LINES TERMINATED BY '\n'
    IGNORE 1 LINES
    (@Id,@TableId,@SaleOrderNo,@showing_invoice,@InvoiceNo,@SaleDate,@TotalAmount,@GrandTotalAmount,@Memo,@DiscountItemCode,@DiscountPrecentag,@PayDollar,@PayRiel,@ReturnDollar,@ReturnReil,@ExchangeRate,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate,@status,@taxamount,@paytype,@visa_card,@paymentDate,@personCount,@prerecieptCount,@roomservice,@tax_name,@tax_phone,@tax_vat,@tax_address)
    SET
        id=@Id,
        dining_table_id=@TableId,
        user_id=1,
        showing_invoice_number=@showing_invoice,
        invoice_number=@InvoiceNo,
        sale_date= @SaleDate,
        exchange_rate= @ExchangeRate,
        person_count = @personCount,
        total_amount= @TotalAmount,
        discount_percentage = @DiscountPrecentag,
        discount_amount = (@TotalAmount * @DiscountPrecentag) / 100,
        tax_amount= @taxamount,
        room_service_amount = @roomservice,
        grand_total = @GrandTotalAmount,
        received_dollar = @PayDollar,
        received_riel = @PayRiel,
        return_dollars = @ReturnDollar,
        return_riels = @ReturnReil,
        finished_dining_date = @paymentDate,
        take_time = 0,
        pre_receipt_print_time= @prerecieptCount,
        receipt_print_time = @prerecieptCount,
        making_status = 0,
        status_code = 0,
        status_code = @status,
        is_secret = true,
        created_at = @CreateDate,
        updated_at = @ModifyDate
    SQL;

        $pdo->exec($query);
    }
}
