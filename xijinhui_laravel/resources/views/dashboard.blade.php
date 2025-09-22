<x-app-layout>
    <div x-data="{code: '', showToast: false}">
        <x-slot name="header">
            <h2 class="font-semibold text-xl text-gray-800 leading-tight">
                {{ __('Dashboard') }}
            </h2>
        </x-slot>

        <div class="py-12">
            <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
                <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                    <div class="p-6 text-gray-900">
                        <x-text-input x-model="code" />
                        <x-primary-button
                            @click="navigator.clipboard.writeText(atob(code)); showToast = true; setTimeout(() => showToast = false, 3000)">Decode</x-primary-button>
                    </div>
                </div>
            </div>

        </div>

        <!-- Toast Notification -->
        <div x-show="showToast" x-transition:enter="transition ease-out duration-300 transform opacity-0 scale-90"
             x-transition:enter-end="opacity-100 scale-100"
             x-transition:leave="transition ease-in duration-300 transform opacity-100 scale-100"
             x-transition:leave-end="opacity-0 scale-90"
             class="fixed top-5 right-5 bg-black text-white px-4 py-2 rounded shadow-lg">
            ✅ Code have been copied to your clipboard successfully!
        </div>
    </div>
</x-app-layout>
