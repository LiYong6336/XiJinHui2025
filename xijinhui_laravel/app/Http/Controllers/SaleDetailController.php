<?php

namespace App\Http\Controllers;

use App\Models\FoodDish;
use App\Models\SaleDetail;
use App\Http\Requests\StoreSaleDetailRequest;
use App\Http\Requests\UpdateSaleDetailRequest;
use App\Models\GeneratedDeletionCode;
use App\Models\SaleTable;
use Carbon\Carbon;
use Illuminate\Http\Request;

class SaleDetailController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create() {}

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreSaleDetailRequest $request)
    {
        $saleDetail = SaleDetail::create($request->validated());

        $saleTable = SaleTable::find($saleDetail->sale_table_id);

        $orderController = new OrderController();

        return $orderController->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));

        //      return  HelperController::modelCretedSuccessfuleMessage($saleDetail);

    }

    /**
     * Display the specified resource.
     */
    public function show(SaleDetail $saleDetail)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateSaleDetailRequest $request, SaleDetail $saleDetail)
    {
        $sale_table = $saleDetail->sale_table;

        if ($saleDetail->qty > $request->qty && ($sale_table->pre_receipt_print_time > 0)) {
            $generatedCode = GeneratedDeletionCode::where('code', base64_encode($request->code))->where('sale_detail_json->id', $saleDetail->id)->first();
            if ($generatedCode) {
                $generatedCode->user_id = auth()->user()->id;
                $generatedCode->used_date = Carbon::now();
                $generatedCode->using_from_db_function = 'decreaseQty';
                $generatedCode->save();
                $generatedCode->delete(); // soft delete
            }
            if (!$generatedCode) {
                return response()->json([
                    'message' => 'code is not correct',
                ], 422);
            }
        }

        $saleDetail->update(array_merge($request->validated(), [
            'discount_percentage' => $request->discount_percentage ?? 0
        ]));
        $saleTable = SaleTable::find($saleDetail->sale_table_id);

        if ($saleDetail->qty <= 0) {
            $saleDetail->delete();
        }

        $orderController = new OrderController();

        return $orderController->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(SaleDetail $saleDetail)
    {
        $saleTable = SaleTable::find($saleDetail->sale_table_id);
        $saleDetail->delete();

        $orderController = new OrderController();

        return $orderController->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }
}
