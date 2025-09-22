<?php

namespace App\Http\Requests;

use App\Models\Stock;
use Illuminate\Foundation\Http\FormRequest;

class UpdateStockRequest extends FormRequest
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
            'operation' => 'required|in:' . implode(',', Stock::Operations),
            'ingredient_id' => 'required|exists:ingredients,id',
            'unit_value' => 'required|numeric',
            'price' => 'required|numeric',
            'note' => 'nullable|string',
        ];
    }
}
