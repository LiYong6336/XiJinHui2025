<?php

use App\Http\Controllers\AnimalPartController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\CategoryController;
use App\Http\Controllers\CustomerController;
use App\Http\Controllers\DiningFloorController;
use App\Http\Controllers\DiningTableController;
use App\Http\Controllers\ExchangeRateController;
use App\Http\Controllers\FoodDishController;
use App\Http\Controllers\FoodDishDetailController;
use App\Http\Controllers\FoodIngredientController;
use App\Http\Controllers\HelperController;
use App\Http\Controllers\IngredientController;
use App\Http\Controllers\OrderController;
use App\Http\Controllers\PaymentController;
use App\Http\Controllers\PaymentMethodController;
use App\Http\Controllers\PrinterController;
use App\Http\Controllers\ReportsController;
use App\Http\Controllers\RoleController;
use App\Http\Controllers\SaleDetailController;
use App\Http\Controllers\SaleTableController;
use App\Http\Controllers\SetInvoiceController;
use App\Http\Controllers\StockController;
use App\Http\Controllers\StockItemController;
use App\Http\Controllers\UserController;
use App\Http\Middleware\LicenseCheck;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/


Route::controller(AuthController::class)->group(function () {
    //  Route::post('register', 'register');
    Route::post('login', 'login');
    Route::post('login_backend', 'login_backend');
});

Route::middleware(['auth:sanctum', LicenseCheck::class])->group(function () {
    Route::post('change_password', [AuthController::class, 'changePassword']);
    Route::apiResource('dining_table', DiningTableController::class);
    Route::apiResource('dining_floor', DiningFloorController::class);
    Route::resource('exchange_rate', ExchangeRateController::class);
    Route::resource('category', CategoryController::class);

    Route::apiResource('set_invoice', SetInvoiceController::class);

    Route::post('getSaleTableAndSaleDetailByTableId', [OrderController::class, 'getSaleTableAndSaleDetailByTableId']);
    Route::post('getPrinterAndUpdateReceiptPrintTime', [OrderController::class, 'getPrinterAndUpdateReceiptPrintTime']);
    Route::post('salePayment', [PaymentController::class, 'salePayment']);

    Route::get('generateDeletionCode', [HelperController::class, 'generateDeletionCode']);
    Route::post('generateDeletionCodeForSaleDetail', [HelperController::class, 'generateDeletionCodeForSaleDetail']);
    Route::post('decreaseQty', [OrderController::class, 'decreaseQty']);
    Route::post('increaseQty', [OrderController::class, 'increaseQty']);
    Route::post('changeQty', [OrderController::class, 'changeQty']);
    Route::post('discountSale', [OrderController::class, 'discountSale']);
    Route::post('discountSaleDetail', [OrderController::class, 'discountSaleDetail']);
    Route::post('discountSaleDetailByCategory', [OrderController::class, 'discountSaleDetailByCategory']);
    Route::post('addSaleDetail', [OrderController::class, 'addSaleDetail']);
    Route::post('print_new_items', [OrderController::class, 'printNewItems']);
    Route::post('split_table', [OrderController::class, 'splitTable']);
    Route::post('change_table', [OrderController::class, 'changeTable']);

    Route::apiResource('ingredients', IngredientController::class);
    Route::apiResource('stocks', StockController::class);
    Route::apiResource('stocks.stock-items', StockItemController::class);
    Route::post('stocks/{stock}/confirm', [StockController::class, 'confirmStock']);
    Route::apiResource('customers', CustomerController::class);
    Route::post('customers/{customer}/topup', [CustomerController::class, 'topup']);
    Route::apiResource('food_dish', FoodDishController::class);
    Route::apiResource('food-dishes.animal-parts', AnimalPartController::class);
    Route::apiResource('animal-parts', AnimalPartController::class);
    // Route::get('food_dish/{foodDish}/animal_parts', [AnimalPartController::class, 'index']);
    // Route::post('food_dish/{foodDish}/animal_parts', [AnimalPartController::class, 'sync']);
    Route::post('food_dish/apply_ingredients', [FoodDishController::class, 'applyIngredients']);


    Route::apiResource('food_dish.food_dish_detail', FoodDishDetailController::class);
    Route::apiResource('food_dish.food_ingredients', FoodIngredientController::class);
    Route::get('getOnlyFoodDish', [FoodDishController::class, 'getOnlyFoodDish']);
    Route::apiResource('printers', PrinterController::class);
    Route::apiResource('sale_details', SaleDetailController::class);
    Route::apiResource('sale_tables', SaleTableController::class);
    Route::post('sale_tables/{sale_table}/cancel', [SaleTableController::class, 'cancel']);
    Route::post('sale_tables/{sale_table}/update-showing-invoice-number', [SaleTableController::class, 'updateShowingInvoiceNumber']);
    Route::post('sale_tables/{sale_table}/pay-owed', [SaleTableController::class, 'payOwed']);
    Route::apiResource('payment_methods', PaymentMethodController::class);

    Route::apiResource('users', UserController::class);
    Route::apiResource('roles', RoleController::class);

    Route::post('logout', [AuthController::class, 'logout']);


    //===Report========================
    Route::get('dailySaleReport', [ReportsController::class, 'dailySaleReport']);
    Route::get('stock-transactions-report', [ReportsController::class, 'stockTransactionReport']);
    Route::get('saleReportByFood', [ReportsController::class, 'saleReportByFood']);
    Route::get('dailyUsage', [ReportsController::class, 'dailyUsage']);
    Route::get('customerTopupReport', [ReportsController::class, 'customerTopupReport']);
});
