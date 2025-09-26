<div>
    <flux:header container class="py-3 border-b border-zinc-200 bg-zinc-50 dark:border-zinc-700 dark:bg-zinc-900">
        <a href="{{ route('table-order', ['t' => $tableId, 'c' => request('c')]) }}" class="ms-2 me-5 flex items-center space-x-2 rtl:space-x-reverse lg:ms-0"
            wire:navigate>
            <x-app-logo />
        </a>
        <flux:spacer />
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

        <div class="flex flex-col -mx-2">
            @forelse($items as $id => $item)
                <div class="w-full flex mb-4 space-x-1">
                    <img src="{{ $item['image'] }}" alt="Product" class="w-24 h-24 object-cover">
                    <div class="w-full">
                        <div class="flex justify-between">
                            <div>
                                <h3 class="font-semibold">{{ $item['name'] }}</h3>
                                <p class="text-gray-600 mt-1">{{ $item['quantity'] }} X ${{ $item['price'] }}</p>
                            </div>
                            <p class="text-2xl font-bold">{{ $item['quantity'] * $item['price'] }}</P>
                        </div>
                        <div class="flex justify-between space-x-2">
                            <div class="flex items-center">
                                <button wire:click="decreaseQty('{{ $id }}')"
                                    class="w-8 h-8 flex items-center justify-center bg-gray-200 text-gray-700 rounded hover:bg-gray-300">
                                    -
                                </button>
                                <span class="w-8 text-center">{{ $item['quantity'] }}</span>
                                <button wire:click="increaseQty('{{ $id }}')"
                                    class="w-8 h-8 flex items-center justify-center bg-gray-200 text-gray-700 rounded hover:bg-gray-300">
                                    +
                                </button>
                            </div>
                            <button wire:click="removeFromCart('{{ $id }}')"
                                class="w-8 h-8 flex items-center justify-center bg-red-500 text-white rounded hover:bg-gray-300">
                                <svg xmlns="http://www.w3.org/2000/svg" class="w-4 h-4" fill="currentColor"
                                    viewBox="0 0 448 512">
                                    <path
                                        d="M135.2 17.7L128 32 32 32C14.3 32 0 46.3 0 64S14.3 96 32 96l384 0c17.7 0 32-14.3 32-32s-14.3-32-32-32l-96 0-7.2-14.3C307.4 6.8 296.3 0 284.2 0L163.8 0c-12.1 0-23.2 6.8-28.6 17.7zM416 128L32 128 53.2 467c1.6 25.3 22.6 45 47.9 45l245.8 0c25.3 0 46.3-19.7 47.9-45L416 128z" />
                                </svg>
                            </button>
                        </div>
                    </div>
                </div>
            @empty
                <p class="py-10 text-center">No items in cart</p>
            @endforelse
        </div>
        <div class="flex flex-col my-2">
            <div class="flex w-full text-right mb-2 text-2xl">
                <span class="w-1/2">Total: </span>
                <span
                    class="w-1/2">{{ collect($items)->reduce(fn($carry, $item) => $carry + $item['price'] * $item['quantity'], 0) }}</span>
            </div>
            <div class="mb-2">
                <flux:modal.trigger name="handle-order">
                    <flux:button class="w-full bg-blue-600" variant="primary" color="blue">Order</flux:button>
                </flux:modal.trigger>
            </div>

            <flux:modal name="handle-order" class="md:w-96">
                <div class="space-y-6">
                    <flux:heading size="lg">Person Count</flux:heading>

                    @for ($i = 1; $i <= 20; $i++)
                        @if ($i == $personCount)
                            <flux:button wire:click="changePersonCount({{ $i }})" variant="primary">
                                {{ $i }}</flux:button>
                        @else
                            <flux:button wire:click="changePersonCount({{ $i }})">{{ $i }}
                            </flux:button>
                        @endif
                    @endfor

                    <div class="flex">
                        <flux:spacer />

                        <flux:button type="button" wire:click="order" variant="primary">Submit</flux:button>
                    </div>
                </div>
            </flux:modal>
        </div>
    </div>
</div>
