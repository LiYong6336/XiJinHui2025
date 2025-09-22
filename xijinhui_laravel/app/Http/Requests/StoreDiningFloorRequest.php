<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreDiningFloorRequest extends FormRequest
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
            'floor_code' => 'required|string|max:20',
            'english_name' => 'string|max:50',
            'chinese_name' => 'string|max:50',
            'khmer_name' => 'string|max:20',
            'remark' => 'string|max:100',
            'description' => 'string|max:100',
        ];
    }
}
