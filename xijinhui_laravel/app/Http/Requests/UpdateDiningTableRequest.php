<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class UpdateDiningTableRequest extends FormRequest
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
            'english_name' => 'required|string|max:20',
            'chinese_name' => 'required|string|max:20',
            'khmer_name' => 'required|string|max:20',

            'dining_table_status' => 'numeric',
            'dining_table_person' => 'numeric',
            'dining_table_description' => 'string|max:100',
            'dining_table_remark' => 'string|max:100',
        ];
    }
}
