import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/animal_part.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class AnimalPartQty extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  FoodDish foodDish;
  AnimalPartQty({
    super.key,
    required this.foodDish,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(20),
      width: 300,
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          TextField(
            controller: controller.animalPartRemarkController,
            keyboardType: TextInputType.number,
            decoration: const InputDecoration(
              labelText: 'Quantity',
            ),
          ),
          const SizedBox(height: 10),
          TextField(
            controller: controller.animalPartQtyController,
            keyboardType: TextInputType.number,
            decoration: const InputDecoration(
              labelText: 'Kilogram',
            ),
          ),
          const SizedBox(height: 10),
          Row(
            children: [
              ElevatedButton(
                onPressed: () {
                  Get.back();
                },
                child: const Text('Close'),
              ),
              const Spacer(),
              IconButton(
                icon: const Icon(Icons.kitchen),
                onPressed: () {
                  controller.getAnimalParts(foodDish);
                  Get.dialog(Dialog(
                    child: AnimalPart(
                      foodDish: foodDish,
                      onSuccess: () {
                        Get.back();
                      },
                    ),
                  ));
                },
              ),
              ElevatedButton(
                style: ElevatedButton.styleFrom(backgroundColor: Colors.green),
                child: const Text('Submit'),
                onPressed: () async {
                  var res = await controller.addSaleDetail(
                    saleTableId: controller.saleTable.value?.id,
                    foodDish: foodDish,
                    //
                    headId: controller.animalPartSelectedIds.value?['h'],
                    tailId: controller.animalPartSelectedIds.value?['t'],
                    wholeId: controller.animalPartSelectedIds.value?['w'],
                    mixId: controller.animalPartSelectedIds.value?['m'],
                    //
                    qty: double.tryParse(
                            controller.animalPartQtyController.text) ??
                        0,
                    remark:
                        "Qty: ${controller.animalPartRemarkController.text}",
                  );
                  if (res) {
                    controller.animalPartQtyController.text = '1';
                    controller.animalPartRemarkController.text = '1';
                    Get.back();
                  }
                },
              ),
            ],
          )
        ],
      ),
    );
  }
}
