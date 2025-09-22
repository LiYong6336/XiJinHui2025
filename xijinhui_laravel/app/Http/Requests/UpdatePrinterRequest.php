<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Support\Facades\Auth;

class UpdatePrinterRequest extends FormRequest
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
            'printer_brand' => 'required|string|max:20',
            'deviceName' => 'required|string|max:20',
            'printer_ip_address' => 'required|string|max:20',
            'port' => 'required|string|max:20',
            'isBle' => 'boolean',
            'printer_type' => 'required|in:network,bluetooth,usb',
            'print_location' => 'nullable|string|max:20',
            'remark' => 'nullable|string|max:100',
            'description' => 'nullable|string|max:100',
        ];
    }
}
