<?php

namespace App\Http\Controllers;

use App\Models\Customer;
use App\Http\Requests\StoreCustomerRequest;
use App\Http\Requests\UpdateCustomerRequest;
use Illuminate\Http\Request;

class CustomerController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        return HelperController::modelGetAllSuccessfuleMessage(Customer::latest()->get());
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreCustomerRequest $request)
    {
        $customer = Customer::create($request->validated());

        return HelperController::modelGetSingleSuccessfulMessage($customer);
    }

    /**
     * Display the specified resource.
     */
    public function show(Customer $customer)
    {
        return HelperController::modelGetSingleSuccessfulMessage($customer);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateCustomerRequest $request, Customer $customer)
    {
        $customer->update($request->validated());
        return HelperController::modelGetSingleSuccessfulMessage($customer);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Customer $customer)
    {
        $customer->delete();
        return response(['message' => 'success'], 201);
    }

    public function topup(Request $request, Customer $customer)
    {
        $request->validate([
            'amount' => 'required|numeric'
        ]);
        if ($request->amount <= 0) {
            return response([
                'message' => 'Amount must be greater then zero',
            ]);
        }

        $topup = $customer->topups()->create([
            'before_balance' => $customer->balance,
            'topup_amount' => $request->amount,
            'after_balance' => $customer->balance + $request->amount,
            'user_id' => auth()->user()->id,
        ]);
        if ($topup) {
            $customer->balance = $customer->balance + $request->amount;
            $customer->save();
        }

        return HelperController::modelGetSingleSuccessfulMessage($topup);
    }
}
