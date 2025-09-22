# Restuarant online

## Config enviroment

```bash
cp .env.example .env
```

Set database configuration in `.env`

## Installation

```bash
composer install
php artisan key:generate
```

### Link storage

```bash
php artisan storage:link
```

### Migrate database and seeder

```bash
php artisan migrate
php artisan db:seed
```

### Restore food photo

copy and paste you photos to: storage/app/public/food_dish

```bash
php artisan app:load-image-from-storage
```

Run above command to set food photo to database
