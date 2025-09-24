<?php

namespace App\Services;

use Illuminate\Support\Facades\Session;

class CartService
{
    protected $sessionKey = 'cart';

    public function getAll()
    {
        return Session::get($this->sessionKey, []);
    }

    public function add($item, $foodDishDetailId = null)
    {
        $cart = $this->getAll();
        $id = $item->id;

        if ($foodDishDetailId) {
            $id = $item->id . '-' . $foodDishDetailId;
        }

        $name = $item->english_name . ' - ' . $item->khmer_name;

        if (isset($cart[$id])) {
            $cart[$id]['quantity']++;
        } else {
            $price = $item->food_price;
            if ($foodDishDetailId) {
                $detail = \App\Models\FoodDishDetail::find($foodDishDetailId);
                if ($detail) {
                    $name = $detail->english_name . ' - ' . $detail->khmer_name . ' - ' . $detail->chinese_name;
                    $price = $detail->price;
                }
            }

            $cart[$id] = [
                'name' =>  $name,
                'price' => $price,
                'image' => $item->food_photo_url ?? asset('assets/images/drink.jpg'),
                'quantity' => 1,
                'food_dish_detail_id' => $foodDishDetailId,
            ];
        }

        Session::put($this->sessionKey, $cart);
        return $cart;
    }

    public function updateQuantity($id, $quantity)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            $cart[$id]['quantity'] = $quantity;
            Session::put($this->sessionKey, $cart);
        }
        return $cart;
    }

    public function increaseQuantity($id, $quantity = 1)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            $cart[$id]['quantity'] += $quantity;
            Session::put($this->sessionKey, $cart);
        }
        return $cart;
    }

    public function decreaseQuantity($id, $quantity = 1)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            $cart[$id]['quantity'] -= $quantity;
            Session::put($this->sessionKey, $cart);
        }
        return $cart;
    }

    public function remove($id)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            unset($cart[$id]);
            Session::put($this->sessionKey, $cart);
        }
        return $cart;
    }

    public function clear()
    {
        Session::forget($this->sessionKey);
        return [];
    }

    public function total()
    {
        $cart = $this->getAll();

        return collect($cart)->reduce(function ($carry, $item) {
            return $carry + ($item['price'] * $item['quantity']);
        }, 0);
    }
}
