<?php

namespace App\Livewire;

use App\Models\DiningTable;
use App\Models\ExchangeRate;
use App\Models\FoodDish;
use App\Models\Order;
use App\Models\SaleDetail;
use App\Models\SaleTable;
use App\Services\CartService;
use Carbon\Carbon;
use Illuminate\Support\Facades\Session;
use Livewire\Component;

class ShowCart extends Component
{
    public $items = [];
    public $tableId;
    public $note = '';
    public $personCount = '';

    public function mount()
    {
        $cartService = app(CartService::class);
        $this->items = $cartService->getAll();
        $this->tableId = request('t');
        $this->personCount = Session::get('personCount', 1);
    }

    public function render()
    {
        return view('livewire.show-cart')->layout('components.layouts.app.cart');
    }

    public function removeFromCart(FoodDish $item): void
    {
        $cartService = app(CartService::class);
        $this->items = $cartService->remove($item->id);
    }

    public function increaseQty($id): void
    {
        $cartService = app(CartService::class);
        if (isset($this->items[$id])) {
            $this->items = $cartService->increaseQuantity($id);
        }
    }

    public function decreaseQty($id): void
    {
        $cartService = app(CartService::class);
        if (isset($this->items[$id]) && $this->items[$id]['quantity'] > 1) {
            $this->items = $cartService->decreaseQuantity($id);
        } else {
            $this->items = $cartService->remove($id);
        }
    }

    public function changePersonCount($i)
    {
        $this->personCount = $i;
        Session::put('personCount', $i, 60);
    }

    public function order()
    {
        if (count($this->items) == 0) {
            session()->flash('error', 'No items in cart.');
            return redirect()->route('table-order', ['t' => $this->tableId]);
        }

        $total = collect($this->items)->reduce(function ($carry, $item) {
            return $carry + ($item['price'] * $item['quantity']);
        }, 0);

        // $order = Order::create([
        //     'dining_table_id' => 1,
        //     'total'=> $total,
        //     'person_count' => $this->personCount,
        //     'note' => $this->note,
        // ]);
        // foreach($this->items as $id => $item) {
        //     $order->orderItems()->create([
        //         'food_dish_id' => $id,
        //         'price' => $item['price'],
        //         'quantity' => $item['quantity'],
        //         'total' => $item['price'] * $item['quantity'],
        //     ]);
        // }
        // $cartService = app(CartService::class);
        // $this->items = $cartService->clear();
        // session()->flash('success', 'Your order has been submitted. Please wait while we prepare it for you as quickly as possible.');
        //
        // return redirect()->route('table-order', ['t' => $this->tableId]);

        $dinningTable = DiningTable::find($this->tableId);
        if (!$dinningTable) {
            session()->flash('error', 'Table not found.');
            return redirect()->route('show-cart', ['t' => $this->tableId]);
        }

        $exchange_rate = ExchangeRate::all()->last()->rate_standard;

        $saleTable = SaleTable::where('dining_table_id', $this->tableId)
            ->where('status_code', 1)
            ->first();

        if (!$saleTable) {
            // session()->flash('error', 'Table: ' . $dinningTable->english_name . ' is being busy.');
            // return redirect()->route('table-order', ['t' => $this->tableId]);
            //return HelperController::modelCretedSuccessfuleMessage($saleTable->load('dining_table', 'dining_table.dining_floor', 'user', 'sale_detail', 'sale_detail.saleDetailIngredients', 'sale_detail.saleDetailIngredients.ingredient'));
            // return response([
            //     'message' => 'Table: ' . $dinningTable->english_name . ' is being busy.',
            // ], Response::HTTP_BAD_REQUEST);

            $saleTable = SaleTable::create([
                'dining_table_id' => $this->tableId,
                'sale_date' => Carbon::now(),
                'exchange_rate' => $exchange_rate,
                'person_count' => $this->personCount,
                'room_service_charge' => $dinningTable->room_service_charge,
                'room_service_fixPrice' => $dinningTable->room_service_fixPrice,
                'status_code' => 1,
            ]);
        }

        foreach ($this->items as $id => $item) {
            $foodDish = FoodDish::findOrFail($id);

            $decription =  $foodDish->english_name . ' - ' . $foodDish->khmer_name; // .' - ' . $foodDish->chinese_name;
            $price = $foodDish->food_price;

            $saleDetail = SaleDetail::create([
                'sale_table_id' => $saleTable->id,
                'description' => $decription,
                'qty' => $item['quantity'],
                'food_price' => $price,
                'food_dish_id' => $foodDish->id,
                //'food_dish_detail_id' => $foodDishDetail ? $foodDishDetail->id : null,
                'food_dish_json' => $foodDish->load('category'),
                //'food_dish_detail_json' => $foodDishDetail,
                //'remark' => $remark,
            ]);
        }

        $cartService = app(CartService::class);
        $cartService->clear();

        session()->flash('success', 'Your order has been submitted. Please wait while we prepare it for you as quickly as possible.');

        return redirect()->route('table-order', ['t' => $this->tableId]);
    }
}
