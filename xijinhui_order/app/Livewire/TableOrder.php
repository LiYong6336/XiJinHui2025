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
    private ?CartService $cartService;

    public function mount()
    {
        $cartService = app(CartService::class);
        $this->carts = $cartService->getAll();

        $category_id = request('c');

        $this->items = FoodDish::where('is_enable', true)
            ->when($category_id, fn($query) => $query->where('category_id', $category_id))
            ->get();
        $this->mapCartQty($this->items);

        $this->categories = Category::all();
    }

    public function render()
    {
        return view('livewire.table-order')->layout('components.layouts.app.cart');
    }

    public function addToCart(FoodDish $item)
    {
        $cartService = app(CartService::class);
        $cartService->add($item);
        $this->carts = $cartService->getAll();
        $this->mapCartQty($this->items);
    }

    private function mapCartQty($foodDishes)
    {
        $carts = $this->carts;
        $this->items = $foodDishes->map(function ($item) use ($carts) {
            $item->cart_qty = $carts[$item->id]['quantity'] ?? 0;
            return $item;
        });
        $this->totalItems = collect($this->carts)->sum('quantity');
    }

}
