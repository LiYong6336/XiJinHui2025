<?php

namespace App\Console\Commands;

use App\Models\FoodDish;
use Illuminate\Console\Command;
use Illuminate\Support\Facades\File;

class FoodPhotoRenamer extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'food-photo-renamer';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Command description';

    /**
     * Execute the console command.
     */
    private int $found = 0;
    public function handle()
    {
        ini_set('memory_limit', '8192M');
        // Define the directories

        $sourcePath = storage_path('found_files');
        //$sourcePath = storage_path('all_files');

        $destinationPath = storage_path('renamed_files');

        $files = File::allFiles($sourcePath);
        $count = count($files);
        foreach($files as $file){
            $fileNameWithoutExt = str_replace('.'.$file->getExtension(), '', $file->getFilename());
            $foodDish = FoodDish::where('chinese_name', 'like', '%'.  $fileNameWithoutExt .'%')
                ->first();


            if($foodDish) {
                $this->info($file->getFilename() . '=================== Found ==================');
                File::copy($file->getPathname(), $destinationPath.'/'.$foodDish->chinese_name . '.'. $file->getExtension());
                $this->found += 1;
            } else {
                $this->warn($file->getFilename());
            }

            sleep(.5);
        }

        $this->info('File copying process completed with ' . $this->found . 'files.');

    }
}
