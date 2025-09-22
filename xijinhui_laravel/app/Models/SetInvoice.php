<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class SetInvoice extends Model
{
    use HasFactory;

    protected $fillable = [
        "invoice_date",
        "invoice_start",
        "invoice_count",
        "invoice_end",
    ];
}
