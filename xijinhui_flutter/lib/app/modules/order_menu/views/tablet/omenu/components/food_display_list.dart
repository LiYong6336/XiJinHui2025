import 'package:cached_network_image/cached_network_image.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/animal_part_qty.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class FoodDisplayList extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  FoodDisplayList({
    super.key,
  });

  Map<int, double> getFoodOrderingCount(List<SaleDetail> list) {
    Map<int, double> carts = <int, double>{};
    for (SaleDetail s in list) {
      if (carts.containsKey(s.foodDishId)) {
        carts[s.foodDishId!] = (carts[s.foodDishId!] ?? 0) + (s.qty ?? 0);
      } else {
        carts[s.foodDishId!] = s.qty ?? 0;
      }
    }
    return carts;
  }

  @override
  Widget build(BuildContext context) {
    return Expanded(
      flex: 1,
      child: Obx(() {
        var foodOrderingCounts = getFoodOrderingCount(controller.saleDetails);
        List<FoodDish> foodDishes =
            controller.search.isEmpty && controller.filteredFoodDishes.isEmpty
                ? controller.foodDishes
                : controller.filteredFoodDishes;
        return GridView.builder(
          itemCount: foodDishes.length,
          gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
            crossAxisCount: 4,
            mainAxisSpacing: 0,
            crossAxisSpacing: 2,
            //childAspectRatio: .42,
            childAspectRatio: .70,
          ),
          itemBuilder: (context, index) {
            FoodDish foodDish = foodDishes[index];
            return InkWell(
              onTap: () => _handleClickItem(foodDish),
              child: Padding(
                padding: const EdgeInsets.all(6.0),
                child: Container(
                  decoration: BoxDecoration(
                    color: Colors.white,
                    boxShadow: const [
                      BoxShadow(color: Colors.black12, blurRadius: 4)
                    ],
                    borderRadius: BorderRadius.circular(12),
                  ),
                  child: Column(
                    //mainAxisAlignment: MainAxisAlignment.center,
                    //mainAxisSize: MainAxisSize.min,
                    children: [
                      Stack(
                        children: [
                          Container(
                            padding: const EdgeInsets.all(10),
                            child: foodDish.foodPhoto == null
                                ? Image.asset(
                                    //'assets/icons/icon.png',
                                    'assets/images/food-dish-placeholder.jpg',
                                    width: 140,
                                    height: 140,
                                    fit: BoxFit.cover,
                                  )
                                : CachedNetworkImage(
                                    imageUrl: foodDish.foodPhotoUrl ?? '',
                                    height: 140,
                                    errorWidget: (context, url, error) =>
                                        Image.asset(
                                      //'assets/icons/icon.png',
                                      'assets/images/food-dish-placeholder.jpg',
                                      width: 140,
                                      height: 140,
                                      fit: BoxFit.cover,
                                    ),
                                  ),
                          ),
                          if (foodOrderingCounts[foodDish.id] != null)
                            Positioned(
                              top: 0,
                              right: 0,
                              child: Container(
                                decoration:
                                    const BoxDecoration(color: Colors.red),
                                padding: const EdgeInsets.all(2),
                                child: Text(
                                  "${foodOrderingCounts[foodDish.id]}",
                                  style: const TextStyle(color: Colors.white),
                                ),
                              ),
                            ),
                        ],
                      ),
                      //const SizedBox(height: 10),
                      Text(foodDish.englishName ?? foodDish.chineseName ?? '',
                          overflow: TextOverflow.ellipsis,
                          maxLines: 1,
                          textAlign: TextAlign.center,
                          style: GoogleFonts.poppins(
                              color: Colors.black,
                              fontSize: 14,
                              fontWeight: FontWeight.w500)),
                      //const SizedBox(height: 10),
                      Text(foodDish.foodPrice.toString(),
                          textAlign: TextAlign.center,
                          style: GoogleFonts.poppins(
                              color: Colors.black,
                              fontSize: 20,
                              fontWeight: FontWeight.bold)),
                    ],
                  ),
                ),
              ),
            );
          },
        );
      }),
    );
  }

  void _handleClickItem(FoodDish item) {
    if (item.category?.isAnimalPart == true) {
      Get.dialog(Dialog(
        child: AnimalPartQty(foodDish: item),
      ));
      return;
    }
    if ((item.foodDishDetails ?? []).isEmpty) {
      controller.addSaleDetail(
        saleTableId: controller.saleTable.value!.id,
        qty: 1,
        foodPrice: item.foodPrice ?? 0.0,
        foodDish: item,
      );
      return;
    }

    Get.dialog(
      Dialog(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            for (FoodDishDetail detail in (item.foodDishDetails ?? []))
              Container(
                width: 300,
                decoration: const BoxDecoration(
                    border: Border(bottom: BorderSide(color: Colors.black12))),
                child: ListTile(
                  onTap: () async {
                    bool success = await controller.addSaleDetail(
                      saleTableId: controller.saleTable.value!.id,
                      qty: 1,
                      foodPrice: item.foodPrice ?? 0.0,
                      foodDish: item,
                      foodDishDetail: detail,
                    );
                    if (success) {
                      Get.back();
                    }
                  },
                  title: Text(detail.englishName ?? ''),
                  trailing: Text('${detail.price}'),
                ),
              )
          ],
        ),
      ),
    );
  }
}
