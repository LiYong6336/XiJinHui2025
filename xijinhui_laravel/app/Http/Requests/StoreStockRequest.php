<?php

namespace App\Http\Requests;

use App\Models\Stock;
use Illuminate\Foundation\Http\FormRequest;

class StoreStockRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return auth()->check();
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        return [
            'invoice_number' => 'nullable|string',
            'operation' => 'required|in:' . implode(',', Stock::Operations),
            'reference' => 'nullable|string',
            'stock_date' => 'nullable|string',
            //'ingredient_id' => 'required|exists:ingredients,id',
            'note' => 'nullable|string',
        ];
    }
}
