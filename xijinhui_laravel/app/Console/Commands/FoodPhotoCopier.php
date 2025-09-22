<?php

namespace App\Console\Commands;

use App\Models\FoodDish;
use Illuminate\Console\Command;
use Illuminate\Support\Facades\File;

class FoodPhotoCopier extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'food-photo-copier';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Command description';

    private int $found = 0;
    /**
     * Execute the console command.
     */
    public function handle()
    {
        ini_set('memory_limit', '8192M');
        // Define the directories

        $sourcePath = 'E:\餐饮美食菜品图高清';//storage_path('all_files');
        //$sourcePath = storage_path('all_files');

        $destinationPath = storage_path('found_files');
        $files = File::allFiles($sourcePath);
        $count = count($files);
        foreach($files as $file){
            $fileNameWithoutExt = str_replace('.'.$file->getExtension(), '', $file->getFilename());
            $exists = FoodDish::where('chinese_name', 'like', '%'.  $fileNameWithoutExt .'%')
                ->exists();




            if($exists) {
                $this->info($file->getFilename() . '=================== Found ==================');
                File::copy($file->getPathname(), $destinationPath.'/'.$file->getFilename());
                $this->found += 1;
            } else {
                $this->warn($file->getFilename());
            }

            sleep(.5);
        }

        $this->info('File copying process completed with ' . $this->found . 'files.');


    }
}
