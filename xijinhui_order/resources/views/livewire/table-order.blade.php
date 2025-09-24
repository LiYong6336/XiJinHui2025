<div>
    <flux:header container class="py-3 border-b border-zinc-200 bg-zinc-50 dark:border-zinc-700 dark:bg-zinc-900">
        <a href="{{ route('table-order') }}" class="ms-2 me-5 flex items-center space-x-2 rtl:space-x-reverse lg:ms-0"
            wire:navigate>
            <x-app-logo />
        </a>

        <flux:spacer />

        <div class="relative">
            <a href="{{ route('show-cart', request()->only(['c', 't'])) }}">
                <svg xmlns="http://www.w3.org/2000/svg" class="w-8 h-8 text-gray-700" fill="none" viewBox="0 0 24 24"
                    stroke="currentColor">
                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                        d="M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-1.293 2.293a1 1 0 00.707 1.707H19m-7 0a1 1 0 110 2 1 1 0 010-2zm6 0a1 1 0 110 2 1 1 0 010-2z" />
                </svg>
                <span
                    class="absolute -top-1 -right-1 bg-red-600 text-white text-xs rounded-full w-5 h-5 flex items-center justify-center">{{ $totalItems }}</span>

            </a>
        </div>
    </flux:header>

    <div class="mx-auto mt-2 w-full [:where(&)]:max-w-7xl px-6 lg:px-8 items-center">

        @if (session()->has('success'))
            <div class="my-5">
                <div x-data="{ show: true }" x-show="show" x-init="setTimeout(() => show = false, 10000)" {{-- class="fixed bottom-4 right-4 bg-green-500 text-white px-4 py-2 rounded shadow-md z-50" --}}
                    class="w-full bg-green-500 text-white px-4 py-2 rounded shadow-md">
                    {{ session('success') }}
                </div>
            </div>
        @endif
        @if (session()->has('error'))
            <div class="my-5">
                <div x-data="{ show: true }" x-show="show" x-init="setTimeout(() => show = false, 10000)"
                    class="w-full bg-red-500 text-white px-4 py-2 rounded shadow-md">
                    {{ session('error') }}
                </div>
            </div>
        @endif

        <div class="w-full flex flex-nowrap overflow-x-auto space-x-1 mb-2">
            <a href="{{ route('table-order') }}"
                class="whitespace-nowrap  bg-{{ !request('c') ? 'blue' : 'green' }}-600 text-white px-3 py-2 rounded-lg hover:bg-blue-700">All</a>
            @foreach ($categories as $c)
                <a href="{{ route('table-order', ['c' => $c->id, 't' => request('t')]) }}"
                    class="whitespace-nowrap {{ request('c') == $c->id ? 'bg-blue-600' : 'bg-green-600' }} text-white px-3 py-2 rounded-lg hover:bg-blue-700">{{ $c->english_name }}</a>
            @endforeach
        </div>
        <div class="flex flex-wrap -mx-2">
            @foreach ($items as $item)
                <div class="relative w-1/2 lg:w-1/3 xl:w-1/4 px-2 mb-4">
                    @if ($item->cart_qty > 0)
                        <span
                            class="absolute right-3 inline-flex items-center rounded-md bg-red-50 px-2 py-1 text-xs font-medium text-red-700 ring-1 ring-red-600/10 ring-inset">{{ $item->cart_qty }}</span>
                    @endif
                    <img src="{{ $item->food_photo_url ?? asset('assets/images/drink.jpg') }}" alt="Product"
                        class="w-full object-cover">
                    <div class="p-4">
                        <h3 class="font-semibold">{{ $item->english_name }}</h3>
                        <p class="text-gray-600 mt-1">${{ $item->food_price }}</p>
                        <button type="button" wire:click="addToCart({{ $item->id }})"
                            class="mt-3 w-full bg-blue-600 text-white py-2 rounded-lg hover:bg-blue-700">Add to Cart
                        </button>
                    </div>
                </div>
            @endforeach
        </div>
    </div>
</div>
