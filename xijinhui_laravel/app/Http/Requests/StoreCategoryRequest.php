<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class StoreCategoryRequest extends FormRequest
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
            'english_name' => 'required|string',
            'chinese_name' => 'nullable|string',
            'khmer_name' => 'nullable|string',
            'category_code' => 'required|unique:categories',
            //'category_photo' => 'image:jpeg,png,jpg,gif,svg|max:1024:mimes:jpeg,png,jpg,gif,svg',
            'printer_id' => 'required|integer',
            'is_animal_part' => 'required|boolean',
        ];
    }
}
