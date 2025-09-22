<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StorePaymentRequest extends FormRequest
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
            'payments' => 'required',
            // 'payments' => 'required|array',
            // 'payments.*.payment_method_id' => 'required|integer',
            // 'payments.*.amount_dollar' => "required|numeric",
            // 'payments.*.amount_riel' => "required|numeric",
        ];
    }
}
