<?php

namespace App\Console\Commands;

use App\Models\FoodDish;
use Illuminate\Console\Command;
use Illuminate\Support\Facades\File;

class LoadImageFromStorage extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'app:load-image-from-storage {replaceExisting?}';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Command description';

    /**
     * Execute the console command.
     */
    public function handle()
    {
        $replaceExisting = $this->argument('replaceExisting');
        $directoryPath = storage_path('app/public/food_dish'); // Assuming images are in 'public/images'

        $files = File::files($directoryPath);
        foreach ($files as $file) {
            if (in_array($file->getExtension(), ['jpg', 'jpeg', 'png', 'gif', 'webp'])) {
                $fileNameWithoutExtension = pathinfo($file->getFilename(), PATHINFO_FILENAME);
                $foodDish = FoodDish::where('english_name', $fileNameWithoutExtension)
                    ->orWhere('chinese_name', $fileNameWithoutExtension)
                    ->orWhere('khmer_name', $fileNameWithoutExtension)
                    ->first();

                if ($foodDish && (($foodDish->food_photo && $replaceExisting) || !$foodDish->food_photo)) {
                    $foodDish->food_photo = 'food_dish/' . $file->getFilename();
                    $foodDish->save();
                }
            }
        }
    }
}
