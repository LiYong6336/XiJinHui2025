import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class AnimalPart extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  FoodDish foodDish;
  Function()? onSuccess;
  AnimalPart({
    super.key,
    required this.foodDish,
    this.onSuccess,
  });

  @override
  Widget build(BuildContext context) {
    return Obx(() {
      return Container(
        padding: const EdgeInsets.all(20),
        child: Column(
          children: [
            Expanded(
              child: SingleChildScrollView(
                scrollDirection: Axis.horizontal,
                child: Row(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    SizedBox(
                      width: 250,
                      child: _buildAnimalPartMaking('h'),
                    ),
                    SizedBox(
                      width: 250,
                      child: _buildAnimalPartMaking('w'),
                    ),
                    SizedBox(
                      width: 250,
                      child: _buildAnimalPartMaking('t'),
                    ),
                    SizedBox(
                      width: 250,
                      child: _buildAnimalPartMaking('m'),
                    ),
                  ],
                ),
              ),
            ),
            Row(
              children: [
                ElevatedButton(
                  child: const Text('Close'),
                  onPressed: () {
                    Get.back();
                  },
                ),
                const Spacer(),
                ElevatedButton(
                  child: const Text('Ok'),
                  onPressed: _handleSubmit,
                ),
              ],
            )
          ],
        ),
      );
    });
  }

  _handleSubmit() async {
    var res = await controller.addSaleDetail(
      saleTableId: controller.saleTable.value?.id,
      foodDish: foodDish,
      //
      headId: controller.animalPartSelectedIds.value?['h'],
      tailId: controller.animalPartSelectedIds.value?['t'],
      wholeId: controller.animalPartSelectedIds.value?['w'],
      mixId: controller.animalPartSelectedIds.value?['m'],
      //
      qty: double.tryParse(controller.animalPartQtyController.text) ?? 0,
      remark: "Qty: ${controller.animalPartRemarkController.text}",
    );
    if (res) {
      controller.animalPartQtyController.text = '1';
      controller.animalPartRemarkController.text = '1';

      controller.animalPartSelectedIds.value?['h'] = null;
      controller.animalPartSelectedIds.value?['t'] = null;
      controller.animalPartSelectedIds.value?['w'] = null;
      controller.animalPartSelectedIds.value?['m'] = null;

      Get.back();
      if (onSuccess != null) {
        onSuccess!();
      }
    }
  }

  _buildAnimalPartMaking(String part) {
    var headName = {'h': 'Head', 'w': 'Whole', 't': 'Tail', 'm': 'Modify'};

    var cookings = controller.animalParts.value?[part] ?? [];
    return Container(
      decoration: BoxDecoration(border: Border.all(width: 1)),
      padding: const EdgeInsets.all(10),
      margin: const EdgeInsets.all(5),
      child: SingleChildScrollView(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(headName[part] ?? ''),
            for (var c in cookings)
              SingleChildScrollView(
                scrollDirection: Axis.horizontal,
                child: Row(
                  children: [
                    Checkbox(
                        value: controller.animalPartSelectedIds.value![part] ==
                            c['id'],
                        onChanged: (checked) {
                          controller.animalPartSelectedIds.value![part] =
                              c['id'];
                          controller.animalPartSelectedIds.refresh();
                        }),
                    Text(getName(c)),
                  ],
                ),
              ),
          ],
        ),
      ),
    );
  }

  String getName(Map c) {
    var name = '';
    if (c['english_name'] != null && c['english_name'] != '') {
      name += c['english_name'] + ' - ';
    }
    if (c['chinese_name'] != null && c['chinese_name'] != '') {
      name += c['chinese_name'] + ' - ';
    }
    if (c['khmer_name'] != null && c['khmer_name'] != '') {
      name += c['khmer_name'];
    }
    return name;
  }
}
