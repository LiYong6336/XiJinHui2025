<x-app-layout>
    <div>
        <x-slot name="header">
            <h2 class="font-semibold text-xl text-gray-800 leading-tight">
                {{ __('Sale Table') }}
            </h2>
        </x-slot>

        <div class="py-12">
            <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
                <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                    <div class="p-6 text-gray-900">
                        <table class="w-full border border-gray-300">
                            <thead>
                                <th class="border px-4 py-2">Invoice Number</th>
                                <th class="border px-4 py-2">Sale Date</th>
                                <th class="border px-4 py-2">Discount</th>
                                <th class="border px-4 py-2">Grand Total</th>
                                <th class="border px-4 py-2">Action</th>
                            </thead>
                            <tbody>
                                @foreach($saleTables as $st)
                                    <tr>
                                        <td class="border px-4 py-2">{{$st->showing_invoice_number}}</td>
                                        <td class="border px-4 py-2">{{$st->sale_date}}</td>
                                        <td class="border px-4 py-2">{{$st->discount_amount}}({{$st->discount_percentage}}%)</td>
                                        <td class="border px-4 py-2">{{$st->grand_total}}</td>
                                        <td class="border px-4 py-2">
                                            <form action="{{route('sale-tables.destroy', $st)}}" method="POST">
                                                @csrf
                                                @method('DELETE')
                                                <x-secondary-button type="submit">Delete</x-secondary-button>
                                            </form>
                                        </td>
                                    </tr>
                                @endforeach
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</x-app-layout>
