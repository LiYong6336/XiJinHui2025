<?php

namespace App\Livewire;

use App\Models\Category;
use App\Models\FoodDish;
use App\Services\CartService;
use Livewire\Component;

class TableOrder extends Component
{
    public $items;
    public $categories;
    public $carts = [];
    public $totalItems = 0;

    public ?FoodDish $selectedFoodDish = null;
    public $selectedFoodDishDetail = null;
    public $showFoodDishDetailModal = false;

    public function mount()
    {
        $cartService = app(CartService::class);
        $this->carts = $cartService->getAll();

        $category_id = request('c');

        $this->items = FoodDish::where('is_enable', true)
            ->when($category_id, fn($query) => $query->where('category_id', $category_id))
            ->with(['foodDishDetails'])
            ->get();
        $this->mapCartQty($this->items);

        $this->categories = Category::all();
    }

    public function render()
    {
        return view('livewire.table-order')->layout('components.layouts.app.cart');
    }

    public function selectFoodDish(FoodDish $item)
    {
        if ($item->foodDishDetails->count() > 0) {
            $this->selectedFoodDish = $item;
            $this->showFoodDishDetailModal = true;
        } else {
            $this->addToCart($item);
        }
    }

    public function addToCart(FoodDish $item, $foodDishDetailId = null)
    {
        $cartService = app(CartService::class);
        $cartService->add($item, $foodDishDetailId);
        $this->carts = $cartService->getAll();
        $this->mapCartQty($this->items);
        $this->closeFoodDishDetailModal();
    }

    public function addSelectedFoodDishToCart()
    {
        $this->addToCart($this->selectedFoodDish, $this->selectedFoodDishDetail);
    }

    public function closeFoodDishDetailModal()
    {
        $this->selectedFoodDish = null;
        $this->selectedFoodDishDetail = null;
        $this->showFoodDishDetailModal = false;
    }

    private function mapCartQty($foodDishes)
    {
        $carts = $this->carts;
        $this->items = $foodDishes->map(function ($item) use ($carts) {
            $item->cart_qty = 0;
            foreach ($carts as $cartId => $cartItem) {
                $cartIdParts = explode('-', (string)$cartId);
                $foodDishId = $cartIdParts[0];
                if ($foodDishId == $item->id) {
                    $item->cart_qty += $cartItem['quantity'];
                }
            }
            return $item;
        });
        $this->totalItems = collect($this->carts)->sum('quantity');
    }
}
