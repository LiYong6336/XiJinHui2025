<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class PayOwed extends Model
{
    use HasFactory;

    protected $fillable = [
        'sale_table_id',
        'paid_at',
        'amount',
        'user_id',
    ];

    protected static function booted()
    {
        static::created(function ($payOwed) {

            $oweMethod = PaymentMethod::owe()->first();
            $saleTable = $payOwed->saleTable;

            $payments = $saleTable->payments()->where('payment_method_id', '<>', $oweMethod->id)->get();

            $totalReceivedDollar = $payments->sum('amount_dollar');
            $totalReceivedRiel = $payments->sum('amount_riel');
            $payOwedAmount = $payOwed->amount;

            $saleTable->update([
                'received_dollar' => $totalReceivedDollar + $payOwedAmount,
                'received_riel' => $totalReceivedRiel,
                'balance_dollars' => max(($totalReceivedDollar + $payOwedAmount + ($totalReceivedRiel / $saleTable->exchange_rate)) - $saleTable->grand_total, 0),
            ]);
        });
    }

    public function saleTable()
    {
        return $this->belongsTo(SaleTable::class);
    }
}
