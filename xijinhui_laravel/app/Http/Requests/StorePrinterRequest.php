<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class StorePrinterRequest extends FormRequest
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
            'printer_brand' => 'required|string|max:50',
            'deviceName' => 'required|string|max:50',
            'printer_ip_address' => 'required|ipaddress',
            'port' => 'required|numeric',
            'isBle' => 'string|max:100',
            'remark' => 'string|max:100',
            'description' => 'string|max:100',

        ];
    }
}
