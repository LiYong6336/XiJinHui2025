<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class UpdateFoodDishRequest extends FormRequest
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
            'category_id' => ['numeric'],
            'food_code' => ['max:50'],
            //'english_name' => ['max:50', 'required_without:chinese_name'],
            //'chinese_name' => ['max:50', 'required_without:english_name'],
            'english_name' => ['max:50'],
            'chinese_name' => ['max:50'],
            'khmer_name' => ['max:50'],
            'description' => ['max:50'],
            'food_price' => ['numeric'],
            'remark' => ['max:50'],
            'food_photo_upload' => ["nullable", "image", "mimes:jpg,jpeg,png,bmp", "max:2048"],
            'english_keyword' => ['max:50'],
            'chinese_keyword' => ['max:50'],
            'thai_keyword' => ['max:50'],
            'display_order' => ['numeric'],
            'is_enable' => ['boolean'],
        ];
    }
}
