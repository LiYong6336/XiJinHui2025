<?php

namespace App\Http\Controllers;

use App\Models\Stock;
use App\Models\StockItem;
use App\Models\Ingredient;
use Illuminate\Http\Request;

class StockItemController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(Stock $stock)
    {
        return HelperController::modelGetAllSuccessfuleMessage($stock->stockItems()->with('item')->get());
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request, Stock $stock)
    {
        if ($stock->operation == 'added') {
            $validated = $request->validate([
                'item_id' => 'required|exists:ingredients,id',
                'quantity' => 'required|numeric',
                //'price' => 'nullable|numeric',
                'note' => 'nullable|string',
                'mfp_date' => 'nullable|string',
                'exp_date' => 'nullable|string',
            ]);
        } else {
            $validated = $request->validate([
                'item_id' => 'required|exists:ingredients,id',
                'quantity' => 'required|numeric',
                'note' => 'nullable|string',
            ]);
        }


        // if ($stock->operation == 'added') {
        //     $qty = $item->quantity + ($request->quantity * $item->un_package * $item->unit_capacity);
        // } else {
        //     $qty = $item->quantity - ($request->quantity * $item->un_package * $item->unit_capacity);
        // }
        $oldQty = $item->quantity ?? 0;
        if ($stock->operation != 'added') {
            $item = Ingredient::find($request->item_id);
            $qty = $item->quantity - ($request->quantity * $item->un_package * $item->unit_capacity);
            $item->quantity = $qty;
            $item->save();

            $stockItem = $stock->stockItems()->create(array_merge($validated, [
                'input_date' => now(),
                'before_quantity' => $oldQty,
                'after_quantity' => $qty,
                'status' => true,
                //'price' => $validated['price'] ?? 0,
            ]));

            $item->transactions()->create([
                'quantity' => $request->quantity,
                'before_quantity' => $oldQty,
                'after_quantity' => $qty,
                'operation' => $stock->operation,
                'transaction_date' => now(),
            ]);
        } else {
            $stockItem = $stock->stockItems()->create(array_merge($validated, [
                'input_date' => now(),
                // 'before_quantity' => $oldQty,
                // 'after_quantity' => $qty,
                //'price' => $validated['price'] ?? 0,
                'status' => false,
            ]));
        }



        // // if ($stock->operation == 'take_to_counter') {
        // //     $item->takeToCounter($request->get('quantity', 1));
        // // } else {
        // $item->quantity = $qty;
        // $item->save();
        // // }
        //
        // $item->transactions()->create([
        //     'quantity' => $request->quantity,
        //     'before_quantity' => $oldQty,
        //     'after_quantity' => $qty,
        //     'operation' => $stock->operation,
        //     'transaction_date' => now(),
        // ]);

        return HelperController::modelGetSingleSuccessfulMessage($stockItem);
    }

    /**
     * Display the specified resource.
     */
    public function show(StockItem $stockItem)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(StockItem $stockItem)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Stock $stock, StockItem $stockItem)
    {
        if ($stock->operation == 'added') {
            $validated = $request->validate([
                'item_id' => 'required|exists:ingredients,id',
                'quantity' => 'required|numeric',
                //'price' => 'nullable|numeric',
                'note' => 'nullable|string',
                'mfp_date' => 'nullable|string',
                'exp_date' => 'nullable|string',
            ]);
        } else {
            $validated = $request->validate([
                'item_id' => 'required|exists:ingredients,id',
                'quantity' => 'required|numeric',
                'note' => 'nullable|string',
            ]);
        }

        $stockItem->update($validated);

        return HelperController::modelGetSingleSuccessfulMessage($stockItem);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Stock $stock, StockItem $stockItem)
    {
        $stockItem->delete();
        return response([
            'message' => 'Stock item deleted.'
        ]);
    }

    public function stockTakeToCounter(Request $request)
    {
        $stock = Stock::firstOrCreate([
            'stock_date' => now()->format('Y-m-d'),
            'user_id' => auth()->user()->id,
            //'operation' => Stock::TAKE_TO_COUNTER
        ]);

        $validated = $request->validate([
            'item_id' => 'required|exists:ingredients,id',
            'quantity' => 'required|integer',
            'note' => 'nullable|string',
        ]);

        $ingredient = Ingredient::find($request->item_id);
        //$warehouse = Warehouse::where('item_id', $item->id)->first();
        // if (!$warehouse) {
        //     $warehouse = Warehouse::create([
        //         'item_id' => $item->id,
        //     ]);
        // }

        $qty = $ingredient->quantity - $request->quantity;

        $oldQty = $ingredient->quantity ?? 0;

        $stockItem = $stock->stockItems()->create(array_merge($validated, [
            'input_date' => now(),
            'before_quantity' => $oldQty,
            'after_quantity' => $qty
        ]));

        $ingredient->takeToCounter($request->get('quantity', 1));

        $ingredient->transactions()->create([
            'quantity' => $request->quantity,
            'before_quantity' => $oldQty,
            'after_quantity' => $qty,
            'operation' => $stock->operation,
            'transaction_date' => now(),
        ]);

        return HelperController::modelGetSingleSuccessfulMessage($stockItem->refresh());
    }
}
