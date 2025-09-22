<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreUserRequest extends FormRequest
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
            'name' => 'nullable|string|max:20',
            'username' => 'required|string|max:20|unique:users,username',
            'email' => 'nullable|email|unique:users,email',
            'password' => 'required|string|min:3',
            'user_locale' => 'required|in:en,zh,kh',
            'phone' => 'nullable',
        ];
    }
}
