import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/omenu/components/cart_view.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/omenu/components/food_display_list.dart';
import 'package:chuanmapo_flutter/app/routes/app_pages.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'components/categories_view.dart';

class OrderMenuBody extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  OrderMenuBody({super.key});

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Expanded(
          flex: 1,
          child: Row(
            children: [
              const SizedBox(width: 5),
              Expanded(
                flex: 3,
                child: Row(
                  children: [
                    Expanded(
                      child: Column(
                        children: [
                          SizedBox(height: Get.height * 0.01),
                          Padding(
                            padding: const EdgeInsets.all(8.0),
                            child: Row(
                              children: [
                                Container(
                                  margin: const EdgeInsets.only(right: 10),
                                  child: IconButton(
                                    onPressed: () {
                                      Get.offAllNamed(Routes.HOME);
                                    },
                                    icon: const Icon(Icons.arrow_back),
                                    // child: Container(
                                    //   //width: Get.width * 0.08,
                                    //   decoration: BoxDecoration(
                                    //     borderRadius: BorderRadius.circular(8),
                                    //     color: Colors.white,
                                    //     border: Border.all(
                                    //       color: Colors.white,
                                    //       width: 2,
                                    //     ),
                                    //   ),
                                    //   child: Center(
                                    //     child: Icon(Icons.arrow_back),
                                    //   ),
                                    // ),
                                  ),
                                ),
                                Expanded(
                                    child: Container(
                                  height: Get.height * 0.06,
                                  decoration: BoxDecoration(
                                    color: Colors.white,
                                    borderRadius: BorderRadius.circular(8),
                                    boxShadow: const [
                                      BoxShadow(
                                          color: Colors.black12, blurRadius: 5)
                                    ],
                                  ),
                                  child: CategoriesView(),
                                ))
                              ],
                            ),
                          ),
                          SizedBox(height: Get.height * 0.01),
                          Padding(
                            padding: const EdgeInsets.only(
                                top: 10, left: 10, right: 10),
                            child: TextField(
                              onChanged: (value) {
                                controller.search.value = value;
                                controller.searchFoodDish(value);
                              },
                              decoration: const InputDecoration(
                                hintText: 'Search food dish',
                                border: OutlineInputBorder(),
                              ),
                            ),
                          ),
                          FoodDisplayList(),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
              const SizedBox(width: 10),
              Expanded(flex: 2, child: CardView())
            ],
          ),
        ),
      ],
    );
  }
}
