<?php

namespace App\Http\Controllers;

use App\Models\CustomerTopup;
use App\Models\SaleDetail;
use App\Models\SaleTable;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class ReportsController extends Controller
{
    //
    public function dailySaleReport(Request $request)
    {
        $dateStart = $request->get('date_start');
        $dateEnd = $request->get('date_end');

        $result =   SaleTable::with('payments', 'dining_table', 'user')
            ->where('sale_date', '>=', $dateStart)
            ->where('sale_date', '<=', $dateEnd)
            ->when($request->has('owed'), function ($query) {
                $query->whereRaw('grand_total > (received_dollar + (received_riel*exchange_rate))');
            });
        if (request()->has('is_secret')) {
            $result = $result->whereNotNull('invoice_number')->where('is_secret', true)
                ->orderBy('invoice_number')->get();
        } else {
            $result = $result->whereNotNull('showing_invoice_number')->where('is_secret', false)
                ->orderBy('showing_invoice_number')->get();
        }

        //->whereNotNull('invoice_number')
        //$result = $result->orderBy('invoice_number')->get();

        return HelperController::modelGetAllSuccessfuleMessage($result);
    }

    public function saleReportByFood(Request $request)
    {
        $dateStart = $request->get('date_start');
        $dateEnd = $request->get('date_end');

        $result =   SaleDetail::select([
            //'food_dish_json->id as food_dish_id',
            DB::raw('SUM(qty) as qty'),
            DB::raw('MIN(food_dish_json) as food_dish_json') // Selects the first JSON in the group
        ])
            ->whereHas('sale_table', function ($query) use ($dateStart, $dateEnd) {
                $query = $query->where('sale_date', '>=', $dateStart)
                    ->where('sale_date', '<=', $dateEnd);
                if (request()->has('is_secret')) {
                    $query = $query->whereNotNull('invoice_number')->where('is_secret', true);
                } else {
                    $query = $query->whereNotNull('showing_invoice_number')->where('is_secret', false);
                }
            })
            ->groupBy('food_dish_id')
            ->orderBy('qty', 'desc')
            ->get();

        return HelperController::modelGetAllSuccessfuleMessage($result);
    }

    public function dailyUsage(Request $request)
    {
        // $dateStart = $request->get('date_start');
        // $dateEnd = $request->get('date_end');
        //
        // $result = DB::table('food_ingredients')
        //     ->join('sale_details', function ($join) {
        //         $join->on('food_ingredients.food_dish_id', '=', 'sale_details.food_dish_id')
        //             //->on('food_ingredients.food_dish_detail_id', '=', 'sale_details.food_dish_detail_id');
        //             ->where(function ($query) {
        //                 $query->whereColumn('food_ingredients.food_dish_detail_id', '=', 'sale_details.food_dish_detail_id')
        //                     ->orWhereNull('sale_details.food_dish_detail_id');
        //             });
        //     })
        //     ->join('sale_tables', 'sale_details.sale_table_id', '=', 'sale_tables.id') // Join with sales table
        //     ->join('ingredients', 'food_ingredients.ingredient_id', '=', 'ingredients.id')
        //     ->whereNotNull('sale_tables.invoice_number')
        //     ->where('sale_tables.is_secret', true)
        //     ->whereBetween('sale_details.created_at', [$dateStart, $dateEnd])
        //     ->groupBy('food_ingredients.ingredient_id')
        //     ->select(
        //         'food_ingredients.ingredient_id',
        //         'ingredients.english_name',
        //         'ingredients.chinese_name',
        //         'ingredients.khmer_name',
        //         DB::raw('SUM(food_ingredients.usage) as total_usage')
        //     )
        //     ->get();
        //
        // return HelperController::modelGetAllSuccessfuleMessage($result);

        $request->validate([
            'start_date' => 'required',
            'end_date' => 'required',
        ]);
        $startDate = $request->get('start_date');
        $endDate = $request->get('end_date');

        $dateRange = [$startDate, $endDate];

        $sales = DB::table('sale_details as sd')
            ->join('sale_tables as st', 'sd.sale_table_id', '=', 'st.id')
            ->join('food_ingredients as fi', 'sd.food_dish_id', '=', 'fi.food_dish_id')
            ->join('ingredients as i', 'fi.ingredient_id', '=', 'i.id')
            ->select(
                DB::raw("CONCAT(i.english_name, ' - ', i.chinese_name, ' - ', i.khmer_name) AS name"),
                DB::raw('(i.quantity/i.unit_capacity/i.un_package) as quantity'),
                //DB::raw('i.unit_capacity as unit_capacity'),
                //DB::raw('SUM(sd.qty) as total_sold_ml'),
                DB::raw('SUM(fi.usage*sd.qty) / i.unit_capacity as total_sale_qty'),
                // DB::raw('0 as stock_in'),
                // DB::raw('0 as take_to_counter'),
                // DB::raw('0 as stock_out')
            )
            //->where('i.name', 'Coca Cola')
            ->whereBetween('sd.created_at', $dateRange)
            ->where('st.status_code', 0)
            ->where('st.is_secret', 1)

            ->groupBy(
                'name',
                'i.unit_capacity',
                'i.un_package',
                'i.quantity'
            )
            ->get()
            ->whereNotNull('name');
        return HelperController::modelGetAllSuccessfuleMessage($sales);
    }

    public function customerTopupReport(Request $request)
    {
        $dateStart = $request->get('date_start');
        $dateEnd = $request->get('date_end');

        $result = CustomerTopup::with('customer')->whereBetween('created_at', [$dateStart, $dateEnd])
            ->when($request->phone, function ($query) use ($request) {
                $query->whereHas('customer', function ($q) use ($request) {
                    $q->where('phone', $request->phone);
                });
            })
            ->get();

        return HelperController::modelGetAllSuccessfuleMessage($result);
    }

    public function stockTransactionReport(Request $request)
    {
        $request->validate([
            'start_date' => 'required',
            'end_date' => 'required',
        ]);
        $startDate = $request->get('start_date');
        $endDate = $request->get('end_date');
        $dateRange = [$startDate, $endDate];
        $transactions = DB::table('ingredient_transactions as it')
            ->join('ingredients as i', 'it.ingredient_id', '=', 'i.id')
            ->select(
                DB::raw("CONCAT(IFNULL(i.english_name, ''), ' - ', IFNULL(i.chinese_name, ''), ' - ', IFNULL(i.khmer_name, '')) AS name"),
                DB::raw('(i.quantity/i.un_package/i.unit_capacity) as quantity'),
                //DB::raw('i.unit_capacity as unit_capacity'),
                DB::raw('SUM(CASE WHEN it.operation = "added" THEN it.quantity ELSE 0 END) as stock_in'),
                DB::raw('SUM(CASE WHEN it.operation NOT IN ("added") THEN it.quantity ELSE 0 END) as stock_out')
            )
            //->where('i.name', 'Coca Cola')
            ->whereBetween('it.transaction_date', $dateRange)
            ->groupBy(
                'name',
                'quantity',
                'i.unit_capacity'
            )
            ->get();
        return HelperController::modelGetAllSuccessfuleMessage($transactions);
    }
}
