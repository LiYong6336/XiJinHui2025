<?php

namespace Database\Seeders;

use App\Models\Role;
use App\Models\SettingMenu;
use App\Models\User;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\File;

class SettingMenuSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        // $json = File::get("database/data/setting_menu.json");
        // $settingMenus = json_decode($json);

        $settingMenus = [
            [
                "english_name" =>  "Settings",
                "chinese_name" =>  "设置",
                "khmer_name" =>  "ការកំណត់",
                "icons_path" => "ObjectGroup",
                "route_path" => null,
                "children" => [

                    [
                        "english_name" =>  "Exchange Rate",
                        "chinese_name" =>  "汇率",
                        "khmer_name" =>  "អត្រាប្តូរប្រាក់",
                        "icons_path" => "MoneyBill",
                        "route_path" => "ExchangeRates"
                    ],
                    [
                        "english_name" =>  "Printers",
                        "chinese_name" =>  "打印机",
                        "khmer_name" =>  "ម៉ាស៊ីនបោះពុម្ព",
                        "icons_path" => "Print",
                        "route_path" => "Printers"
                    ],
                    [
                        "english_name" =>  "Roles",
                        "chinese_name" =>  "角色",
                        "khmer_name" =>  "តួនាទី",
                        "icons_path" => "CriticalRole",
                        "route_path" => "Roles"
                    ],
                    [
                        "english_name" =>  "Users",
                        "chinese_name" =>  "用户",
                        "khmer_name" =>  "អ្នកប្រើ",
                        "icons_path" => "CriticalRole",
                        "route_path" => "Users"
                    ],
                    [
                        "english_name" =>  "Change Password",
                        "chinese_name" =>  "更改密码",
                        "khmer_name" =>  "ផ្លាស់ប្តូរពាក្យសម្ងាត់",
                        "icons_path" => "Cog",
                        "route_path" => "ChangePassword"
                    ],
                ]
            ],
            [
                "english_name" =>  "Restuarant",
                "chinese_name" =>  "餐厅",
                "khmer_name" =>  "ភោជនីយដ្ឋាន",
                "icons_path" => "ObjectGroup",
                "route_path" => null,
                "children" => [
                    [
                        "english_name" =>  "Categories",
                        "chinese_name" =>  "类别",
                        "khmer_name" =>  "ប្រភេទ",
                        "icons_path" => "ObjectGroup",
                        "route_path" => "Categories"
                    ],
                    [
                        "english_name" =>  "Floor",
                        "chinese_name" =>  "餐饮楼层",
                        "khmer_name" =>  "ជាន់បរិភោគអាហារ",
                        "icons_path" => "BowlFood",
                        "route_path" => "DiningFloors"
                    ],
                    [
                        "english_name" =>  "Table",
                        "chinese_name" =>  "餐桌",
                        "khmer_name" =>  "តុបរិភោគអាហារ",
                        "icons_path" => "Stairs",
                        "route_path" => "DiningTables"
                    ],
                    [
                        "english_name" =>  "Items",
                        "chinese_name" =>  "食物菜肴",
                        "khmer_name" =>  "ចានអាហារ",
                        "icons_path" => "Spoon",
                        "route_path" => "FoodDishes"
                    ],

                    [
                        "english_name" =>  "Customers",
                        "chinese_name" =>  "顾客",
                        "khmer_name" =>  "អតិថិជន",
                        "icons_path" => "CriticalRole",
                        "route_path" => "Customers"
                    ],
                ]
            ],
            [
                "english_name" =>  "Reports",
                "chinese_name" =>  "报告",
                "khmer_name" =>  "របាយការ",
                "icons_path" => "CriticalRole",
                "route_path" => null,
                "children" => [
                    [
                        "english_name" =>  "Sale Reports",
                        "chinese_name" =>  "销售报告",
                        "khmer_name" =>  "របាយការលក់",
                        "icons_path" => "Users",
                        "route_path" => "Reports.SaleReport"
                    ],

                    [
                        "english_name" =>  "Topup Information",
                        "chinese_name" =>  "充值信息",
                        "khmer_name" =>  "ព័ត៌មានបញ្ចូលទឹកប្រាក់",
                        "icons_path" => "Users",
                        "route_path" => "Reports.TopupInformation"
                    ],
                    [
                        "english_name" =>  "Owed",
                        "chinese_name" =>  "欠单",
                        "khmer_name" =>  "ជំពាក់",
                        "icons_path" => "Spoon",
                        "route_path" => "Owed"
                    ],
                ]
            ], // end report
            [
                "english_name" =>  "Stock",
                "chinese_name" =>  "库存",
                "khmer_name" =>  "ស្តុក",
                "icons_path" => "CriticalRole",
                "route_path" => null,
                "children" => [
                    [
                        "english_name" =>  "Ingredient",
                        "chinese_name" =>  "成分比例表",
                        "khmer_name" =>  "គ្រឿងផ្សំ",
                        "icons_path" => "CriticalRole",
                        "route_path" => "Ingredients"
                    ],
                    [
                        "english_name" =>  "Stock In",
                        "chinese_name" =>  "入库",
                        "khmer_name" =>  "ចូលស្តុក",
                        "icons_path" => "CriticalRole",
                        "route_path" => "StockIns"
                    ],
                    [
                        "english_name" =>  "Adjust Stock",
                        "chinese_name" =>  "调整库存",
                        "khmer_name" =>  "ចេញស្តុក",
                        "icons_path" => "CriticalRole",
                        "route_path" => "StockOuts"
                    ],
                    // [
                    //     "english_name" =>  "Adjust Counter Stock",
                    //     "chinese_name" =>  "Adjust Counter Stock",
                    //     "khmer_name" =>  "Adjust Counter Stock",
                    //     "icons_path" => "CriticalRole",
                    //     "route_path" => "StockCounterAdjust"
                    // ],
                ]
            ],
            [
                "english_name" =>  "Secret",
                "chinese_name" =>  "秘密",
                "khmer_name" =>  "សម្ងាត់",
                "icons_path" => "CriticalRole",
                "route_path" => null,
                "children" => [
                    [
                        "english_name" => "Set Invoices",
                        "chinese_name" => "设定发票数量",
                        "khmer_name" => "កំណត់វិក័យប័ត្រ",
                        "icons_path" => "CriticalRole",
                        "route_path" => "SetInvoices"
                    ],
                    [
                        "english_name" => "Tax Declaration",
                        "chinese_name" => "税务申报",
                        "khmer_name" => "ការប្រកាសពន្ធ",
                        "icons_path" => "CriticalRole",
                        "route_path" => "TaxDeclaration"
                    ],
                    [
                        "english_name" => "Reports Secret",
                        "chinese_name" => "机密报表",
                        "khmer_name" => "របាយការណ៍សម្ងាត់",
                        "icons_path" => "Users",
                        "route_path" => null,
                        "children" => [
                            [
                                "english_name" => "Sale by Item",
                                "chinese_name" => "按菜品销售",
                                "khmer_name" => "ការលក់តាមម្ហូប",
                                "icons_path" => "Users",
                                "route_path" => "Reports.SaleReportByFood"
                            ],
                            [
                                "english_name" => "Sale Report Secret",
                                "chinese_name" => "机密销售报告",
                                "khmer_name" => "របាយការលក់សម្ងាត់",
                                "icons_path" => "Users",
                                "route_path" => "Reports.SaleReportSecret"
                            ],
                            [
                                "english_name" => "Daily Usage",
                                "chinese_name" => "每日使用",
                                "khmer_name" => "ការប្រើប្រាស់ប្រចាំថ្ងៃ",
                                "icons_path" => "Users",
                                "route_path" => "Reports.DailyUsageReport"
                            ],
                            [
                                "english_name" => "Stock Transactions",
                                "chinese_name" => "库存交易",
                                "khmer_name" => "ប្រតិបត្តិការផលិតផលស្តុក",
                                "icons_path" => "Users",
                                "route_path" => "Reports.StockTransactionReport"
                            ],
                        ],
                    ],
                ]
            ],
        ];

        $role = Role::whereIn('name', ['SuperAdmin', 'Admin'])->get();
        $this->createMenu($settingMenus, $role, null);
    }

    private function createMenu(array $menuList, $roles, ?int $parent_id)
    {
        foreach ($menuList as $key => $value) {
            $menu = SettingMenu::firstOrCreate([
                'parent_id' => $parent_id,
                'english_name' => $value['english_name'],
                'chinese_name' => $value['chinese_name'],
                'khmer_name' => $value['khmer_name'],
                'icons_path' => $value['icons_path'],
                'route_path' => $value['route_path'],
            ]);
            foreach ($roles as $role) {
                $ignoreMenuForAdmin = [
                    'Secret',
                    'Set Invoices',
                    'Tax Declaration',
                    'Reports Secret',
                    'Sale by Item',
                    'Sale Report Secret',
                    'Daily Usage',
                ];
                if ($role->name == 'Admin' && in_array($menu->english_name, $ignoreMenuForAdmin)) {
                    //
                } else {
                    $role->settingMenus()->attach($menu);
                }
            }

            if (isset($value['children'])) {
                $this->createMenu($value['children'], $roles, $menu->id);
            }
        }
    }
}
