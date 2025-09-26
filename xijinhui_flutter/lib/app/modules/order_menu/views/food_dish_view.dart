import 'package:cached_network_image/cached_network_image.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/animal_part_qty.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class FoodDishView extends GetView<OrderMenuController> {
  const FoodDishView({super.key});

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
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
            onPressed: () {
              Get.offAllNamed('home');
            },
            icon: const Icon(Icons.arrow_back)),
        title: const Text('Order Menu'),
        centerTitle: true,
      ),
      body: Obx(
        () {
          var foodOrderingCounts =
              getFoodOrderingCount(controller.saleDetails ?? []);
          List<FoodDish> foodDishList = controller.search.value.isEmpty &&
                  controller.filteredFoodDishes.isEmpty
              ? controller.foodDishes
              : controller.filteredFoodDishes;
          return Column(
            children: [
              Padding(
                padding: const EdgeInsets.only(top: 10, left: 10, right: 10),
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
              Expanded(
                child: GridView.count(
                  primary: false,
                  padding: const EdgeInsets.all(10),
                  crossAxisSpacing: 10,
                  mainAxisSpacing: 10,
                  crossAxisCount: 3,
                  children: <Widget>[
                    for (FoodDish item in foodDishList)
                      Card(
                        child: InkWell(
                          onTap: () => _handleClickItem(item),
                          child: Stack(
                            // mainAxisSize: MainAxisSize.min,
                            alignment: Alignment.center,
                            children: <Widget>[
                              if (item.foodPhotoUrl != null)
                                CachedNetworkImage(
                                  imageUrl: item.foodPhotoUrl!,
                                  width: 250,
                                  height: 250,
                                  fit: BoxFit.cover,
                                  errorWidget: (context, url, error) =>
                                      const Icon(
                                    Icons.image,
                                    size: 50,
                                    color: Colors.grey,
                                  ),
                                ),
                              if (item.foodPhoto == null)
                                Image.asset(
                                  'assets/icons/icon.png',
                                  width: 250,
                                  height: 250,
                                  fit: BoxFit.cover,
                                ),
                              Positioned.fill(
                                // width: double.infinity,
                                child: Column(
                                  children: [
                                    const Spacer(),
                                    Container(
                                      alignment: Alignment.bottomCenter,
                                      width: double.infinity,
                                      height: 40,
                                      padding: const EdgeInsets.only(bottom: 5),
                                      color: const Color.fromRGBO(
                                          49, 37, 37, 0.498),
                                      child: SingleChildScrollView(
                                        child: Column(
                                          mainAxisAlignment:
                                              MainAxisAlignment.start,
                                          children: [
                                            Text(
                                              "${item.chineseName}",
                                              style: const TextStyle(
                                                  fontSize: 10,
                                                  color: Colors.white),
                                              textAlign: TextAlign.center,
                                            ),
                                            Text(
                                              "${item.foodPrice}",
                                              style: const TextStyle(
                                                  fontSize: 10,
                                                  color: Colors.white),
                                              textAlign: TextAlign.center,
                                            ),
                                          ],
                                        ),
                                      ),
                                    )
                                  ],
                                ),
                              ),
                              if (foodOrderingCounts[item.id] != null)
                                Positioned(
                                  top: 0,
                                  right: 0,
                                  child: Container(
                                    decoration:
                                        const BoxDecoration(color: Colors.red),
                                    padding: const EdgeInsets.all(2),
                                    child: Text(
                                      "${foodOrderingCounts[item.id]}",
                                      style:
                                          const TextStyle(color: Colors.white),
                                    ),
                                  ),
                                )
                            ],
                          ),
                        ),
                      )
                  ],
                ),
              )
            ],
          );
        },
      ),
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
