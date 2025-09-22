<?php

namespace App\Http\Controllers;

use App\Models\AnimalPart;
use App\Models\DiningTable;
use App\Models\ExchangeRate;
use App\Models\FoodDish;
use App\Models\FoodDishDetail;
use App\Models\GeneratedDeletionCode;
use App\Models\Printer;
use App\Models\SaleDetail;
use App\Models\SaleTable;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class OrderController extends Controller
{
    //
    public function getSaleTableAndSaleDetailByTableId(Request $request)
    {
        $dining_table_id = $request->get('dining_table_id');
        $exRate = ExchangeRate::latest()->first();
        if (!$exRate) {
            return response()->json([
                'message' => 'exchange rate not found'
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }
        $exchange_rate = $exRate->rate_standard ?? 4100;

        $dinningTable = DiningTable::find($dining_table_id);
        $saleTable = SaleTable::with('dining_table', 'dining_table.dining_floor', 'user', 'sale_detail')->where('dining_table_id', $dinningTable->id)->where('status_code', 1)->first();

        if ($saleTable) {
            return HelperController::modelCretedSuccessfuleMessage($saleTable);
        }

        $createSaleTable = SaleTable::create([
            'dining_table_id' => $dining_table_id,
            'sale_date' => Carbon::now(),
            'exchange_rate' => $exchange_rate,
            'person_count' => $request->get('person_count'),
            'room_service_charge' => $dinningTable->room_service_charge,
            'room_service_fixPrice' => $dinningTable->room_service_fixPrice,
            'status_code' => 1,
            'user_id' => auth()->user()->id,
        ]);

        $createSaleTable = SaleTable::with('dining_table', 'dining_table.dining_floor', 'user', 'sale_detail')->where('dining_table_id', $dinningTable->id)->where('status_code', '>', 0)->first();

        return HelperController::modelCretedSuccessfuleMessage($createSaleTable);
    }

    public function addSaleDetail(Request $request)
    {
        $request->validate([
            'food_dish_id' => 'required|integer',
            'food_dish_detail_id' => 'nullable|integer',
            'sale_table_id' => 'required|uuid',
            'dining_table_id' => 'required|integer',
        ]);
        $foodDish = FoodDish::findOrFail($request->food_dish_id);

        $foodDishDetail = null;
        if ($request->food_dish_detail_id) {
            $foodDishDetail = FoodDishDetail::findOrFail($request->food_dish_detail_id);
        }

        $partObj = ['h' => 'Head', 'w' => 'Whole', 't' => 'Tail', 'm' => 'Mix'];
        $remark = null;
        if ($request->remark) {
            $remark = $request->remark . ' | ';
        }

        $animalParts = AnimalPart::whereIn('id', [$request->head_id, $request->tail_id, $request->whole_id, $request->mix_id])->get();
        if ($animalParts->count()) {
            foreach ($animalParts as $ap) {
                $remark .=  $partObj[$ap->type] . ': ';
                if ($ap->english_name) {
                    $remark .= $ap->english_name . ' - ';
                }
                if ($ap->chinese_name) {
                    $remark .= $ap->chinese_name . ' - ';
                }
                if ($ap->khmer_name) {
                    $remark .= $ap->khmer_name;
                }
                $remark .= ' | ';
            }
        }
        $remark = trim($remark, ' | ');

        $decription =  ($foodDishDetail ? '(' . ($foodDishDetail->english_name ?? $foodDishDetail->chinese_name ?? $foodDishDetail->khmer_name) . ') ' : '') .
            ($foodDish->english_name ? $foodDish->english_name . ' - ' : '') .
            ($foodDish->chinese_name ? $foodDish->chinese_name . ' - ' : '') .
            $foodDish->khmer_name;

        $price = $foodDishDetail ? $foodDishDetail->price : $foodDish->food_price;

        SaleDetail::create([
            'sale_table_id' => $request->sale_table_id,
            'description' => $decription,
            'qty' => $request->get('qty', 1),
            'food_price' => $price,
            'food_dish_id' => $foodDish->id,
            'food_dish_detail_id' => $foodDishDetail ? $foodDishDetail->id : null,
            'food_dish_json' => $foodDish->load('category', 'category.printer'),
            'food_dish_detail_json' => $foodDishDetail,
            'remark' => $remark,
        ]);

        return $this->getSaleTableAndSaleDetailByTableId($request);
    }

    public function increaseQty(Request $request)
    {
        $validated = $request->validate([
            'sale_detail_id' => 'required|integer',
            'dining_table_id' => 'required|integer',
        ]);

        $saleDetail = SaleDetail::find($request->sale_detail_id);
        $saleDetail->qty = $saleDetail->qty + 1;
        $saleDetail->save();

        return $this->getSaleTableAndSaleDetailByTableId($request);
    }

    // help create method decreaseQty
    public function decreaseQty(Request $request)
    {
        $validated = $request->validate([
            'sale_detail_id' => 'required|integer',
            'dining_table_id' => 'required|integer',
        ]);
        $saleDetail = SaleDetail::find($request->sale_detail_id);
        $sale_table = SaleTable::find($saleDetail->sale_table_id);




        if ($sale_table->pre_receipt_print_time == 0) {
            if ($saleDetail->qty <= 1) {
                $saleDetail->delete();
                return $this->getSaleTableAndSaleDetailByTableId($request);
            }
            $saleDetail->qty = $saleDetail->qty - 1;
            $saleDetail->save();

            return $this->getSaleTableAndSaleDetailByTableId($request);
        } else {
            $generatedCode = GeneratedDeletionCode::where('code', base64_encode($request->code))->where('sale_detail_json->id', $saleDetail->id)->first();
            if ($generatedCode) {
                if ($saleDetail->qty <= 1) {
                    $saleDetail->delete();
                    return $this->getSaleTableAndSaleDetailByTableId($request);
                }
                $saleDetail->qty = $saleDetail->qty - 1;
                $saleDetail->save();
                $generatedCode->user_id = auth()->user()->id;
                $generatedCode->used_date = Carbon::now();
                $generatedCode->using_from_db_function = 'decreaseQty';
                $generatedCode->save();
                $generatedCode->delete(); // soft delete
                return $this->getSaleTableAndSaleDetailByTableId($request);
            }
            return response()->json([
                'message' => 'code is not correct',
            ], 401);
        }
    }

    public function changeQty(Request $request)
    {
        $validated = $request->validate([
            'sale_detail_id' => 'required|integer',
            'dining_table_id' => 'required|integer',
            'qty' => 'required|numeric',
        ]);

        $saleDetail = SaleDetail::find($request->sale_detail_id);
        $sale_table = SaleTable::find($saleDetail->sale_table_id);

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
                ], 401);
            }
        }

        if ($request->qty <= 0) {
            $saleDetail->delete();
            return $this->getSaleTableAndSaleDetailByTableId($request);
        }

        $saleDetail->qty = $request->qty;
        $saleDetail->save();

        return $this->getSaleTableAndSaleDetailByTableId($request);
    }

    public function discountSale(Request $request)
    {
        $sale_table_id = $request->get('sale_table_id');
        $discount_percentage = $request->get('discount_percentage');
        $saleTable = SaleTable::find($sale_table_id);
        $saleTable->discount_percentage = $discount_percentage;
        $saleTable->save();

        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }
    public function discountSaleDetail(Request $request)
    {
        $sale_detail_id = $request->get('sale_detail_id');
        $discount_percentage = $request->get('discount_percentage');
        $saleDetail = SaleDetail::find($sale_detail_id);

        $saleDetail->discount_percentage = $discount_percentage;
        $saleDetail->save();
        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleDetail->sale_table->dining_table_id]));
    }
    public function discountSaleDetailByCategory(Request $request)
    {
        $sale_table_id = $request->get('sale_table_id');
        $category_ids = $request->get('category_ids');
        $saleTable = SaleTable::find($sale_table_id);
        //        $saleTable->sale_detail->whereIn('id', $category_ids)->update([
        //            'discount_percentage' => $request->get('discount_percentage')
        //        ]);
        $saleDetails = $saleTable->sale_detail()->whereIn('food_dish_json->category_id', $category_ids)->get();
        foreach ($saleDetails as $saleDetail) {
            $saleDetail->discount_percentage = $request->get('discount_percentage');
            $saleDetail->save();
        }
        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }

    public function getPrinterAndUpdateReceiptPrintTime(Request $request)
    {
        $saleTable = SaleTable::find($request->get('sale_table_id'));
        $saleTable->pre_receipt_print_time = $saleTable->pre_receipt_print_time + 1;
        $saleTable->save();
        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }

    public function printNewItems(Request $request)
    {
        $saleTable = SaleTable::findOrFail($request->sale_table_id);
        foreach ($saleTable->sale_detail as $saleDetail) {
            if ($saleDetail->qty > $saleDetail->old_qty) {
                $saleDetail->old_qty = $saleDetail->qty;
                $saleDetail->save();
            }
        }
        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }

    public function splitTable(Request $request)
    {
        $request->validate([
            'sale_table_id' => 'required',
            'new_details' => 'required|array',
        ]);

        $saleTable = SaleTable::findOrFail($request->sale_table_id);

        $newDetails = gettype($request->new_details) == 'string' ? json_decode($request->new_details, true) : $request->new_details ?? [];

        $newSaleTable = $saleTable->replicate();
        $newSaleTable->save();
        foreach ($saleTable->sale_detail as $saleDetail) {
            foreach ($newDetails as $newDetail) {
                $newDetail = gettype($newDetail) == 'string' ? json_decode($newDetail, true) : $newDetail;
                if ($saleDetail->id == $newDetail['id']) {


                    if ($saleDetail->qty > $newDetail['qty']) {
                        $saleDetail->qty = $saleDetail->qty - $newDetail['qty'];
                        $saleDetail->save();
                        $newSaleDetail = $saleDetail->replicate()->fill([
                            'qty' => $newDetail['qty'],
                            'sale_table_id' => $newSaleTable->id,
                        ]);
                        $newSaleDetail->save();
                    } else {
                        $saleDetail->update([
                            'sale_table_id' => $newSaleTable->id
                        ]);
                    }
                }
            }
        }
        return $this->getSaleTableAndSaleDetailByTableId(new Request(['dining_table_id' => $saleTable->dining_table_id]));
    }

    public function changeTable(Request $request)
    {
        $request->validate([
            'dining_table_id' => 'required|integer',
            'sale_table_id' => 'required',
        ]);
        $saleTable = SaleTable::findOrFail($request->sale_table_id);
        $saleTable->dining_table_id = $request->dining_table_id;
        $saleTable->save();

        return $this->getSaleTableAndSaleDetailByTableId($request);
    }

    
}
