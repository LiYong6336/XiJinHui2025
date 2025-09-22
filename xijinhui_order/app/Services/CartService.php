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

    public function add($item)
    {
        $cart = $this->getAll();
        $id = $item->id;

        if (isset($cart[$id])) {
            $cart[$id]['quantity']++;
        } else {
            $cart[$id] = [
                'name' => $item->english_name,
                'price' => $item->food_price,
                'image' => $item->food_photo_url ?? asset('assets/images/drink.jpg'),
                'quantity' => 1
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

    public function increaseQuantity($id, $quantity=1)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            $cart[$id]['quantity']+=$quantity;
            Session::put($this->sessionKey, $cart);
        }
        return $cart;
    }

    public function decreaseQuantity($id, $quantity=1)
    {
        $cart = $this->getAll();

        if (isset($cart[$id])) {
            $cart[$id]['quantity']-=$quantity;
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
