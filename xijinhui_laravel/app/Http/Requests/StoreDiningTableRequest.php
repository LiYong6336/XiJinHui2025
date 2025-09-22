<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class StoreDiningTableRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return Auth::check();
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        return [
            'dining_table_code' => 'required|string|max:20',
            //'dining_table_name' => 'required|string|max:20',
            'english_name' => 'max:20',
            'chinese_name' => 'max:20',
            'khmer_name' => 'max:20',

            'dining_floor_id' => 'required',
        ];
    }
}
