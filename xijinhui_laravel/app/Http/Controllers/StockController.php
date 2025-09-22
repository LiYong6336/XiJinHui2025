<?php

namespace App\Http\Controllers;

use App\Models\Stock;
use App\Http\Requests\StoreStockRequest;
use App\Http\Requests\UpdateStockRequest;
use App\Models\Ingredient;
use Illuminate\Http\Request;

class StockController extends Controller
{
    const LazyLoading = ['user'];
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $stocks = Stock::with(self::LazyLoading)
            ->withCount('stockItems');
        if (request('stock_type') == 'in') {
            $stocks = $stocks->where('operation', 'added');
        } else {
            $stocks = $stocks->where('operation', '<>', 'added');
        }
        $stocks = $stocks->latest()->paginate(100);

        return response($stocks);
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreStockRequest $request)
    {
        //$ingredient = Ingredient::findOrFail($request->ingredient_id);
        $stock = Stock::create(array_merge($request->validated(), [
            'user_id' => auth()->user()->id,
            'stock_date' => $request->get('stock_date', now())
        ]));

        return HelperController::modelGetSingleSuccessfulMessage($stock->refresh()->load(self::LazyLoading));
    }

    /**
     * Display the specified resource.
     */
    public function show(Stock $stock)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Stock $stock)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateStockRequest $request, Stock $stock)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Stock $stock)
    {
        $stock->delete();
        return response([
            'message' => 'Stock delete successfully.'
        ]);
    }

    public function confirmStock(Request $request, Stock $stock)
    {
        foreach ($stock->stockItems as $stockItem) {

            $item = $stockItem->item;

            if ($stock->operation == 'added') {
                $qty = $item->quantity + ($stockItem->quantity * $item->un_package * $item->unit_capacity);
            } else {
                $qty = $item->quantity - ($stockItem->quantity * $item->un_package * $item->unit_capacity);
            }

            $oldQty = $item->quantity ?? 0;

            $item->quantity = $qty;
            $item->save();

            $stockItem->update([
                'before_quantity' => $oldQty,
                'after_quantity' => $qty,
            ]);

            $item->transactions()->create([
                'quantity' => $stockItem->quantity,
                'before_quantity' => $oldQty,
                'after_quantity' => $qty,
                'operation' => $stock->operation,
                'transaction_date' => now(),
            ]);
        }

        $stock->status = true;
        $stock->save();

        return HelperController::modelGetSingleSuccessfulMessage($stock);
    }
}
