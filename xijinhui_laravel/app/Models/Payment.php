<?php

namespace App\Models;

use Carbon\Carbon;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Payment extends Model
{
    use HasFactory;

    protected $table = 'payments';
    protected $fillable = [
        'sale_table_id',
        'payment_method_id',
        'user_id',
        'amount_dollar',
        'amount_riel',
    ];

    public function saleTable()
    {
        return $this->belongsTo(SaleTable::class);
    }

    protected static function booted()
    {
        static::created(function ($payment) {

            $oweMethod = PaymentMethod::owe()->first();
            $payments = $payment->saleTable->payments()->where('payment_method_id', '<>', $oweMethod->id)->get();

            $totalReceivedDollar = $payments->sum('amount_dollar');
            $totalReceivedRiel = $payments->sum('amount_riel');
            $payment->saleTable->update([
                'received_dollar' => $totalReceivedDollar,
                'received_riel' => $totalReceivedRiel,
                'balance_dollars' => ($totalReceivedDollar + ($totalReceivedRiel / $payment->saleTable->exchange_rate)) - $payment->saleTable->grand_total,
            ]);
        });
    }

    public function paymentMethod()
    {
        return $this->belongsTo(PaymentMethod::class);
    }
}
