import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class DiscountPercentage extends GetView<OrderMenuController> {
  final int typeToDiscount;
  final int? saleDetailId;
  final String? saleId;

  const DiscountPercentage({
    super.key,
    required this.typeToDiscount,
    this.saleDetailId,
    this.saleId,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 400,
      padding: const EdgeInsets.all(10),
      child: Column(mainAxisSize: MainAxisSize.min, children: [
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 5;
                    },
                    child: const Text('5%'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 10;
                    },
                    child: const Text('10%'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 15;
                    },
                    child: const Text('15%'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 20;
                    },
                    child: const Text('20%'))),
          ],
        ),
        const SizedBox(
          height: 10,
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 25;
                    },
                    child: const Text('25%'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 1,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 30;
                    },
                    child: const Text('30%'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 2,
                child: ElevatedButton(
                    onPressed: () {
                      controller.discountPercentage.value = 32;
                    },
                    child: const Text('32%'))),
          ],
        ),
        const SizedBox(
          height: 10,
        ),
        Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 35;
                  },
                  child: const Text('35%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 40;
                  },
                  child: const Text('40%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 50;
                  },
                  child: const Text('50%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 60;
                  },
                  child: const Text('60%'))),
        ]),
        const SizedBox(
          height: 10,
        ),
        Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 70;
                  },
                  child: const Text('70%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 80;
                  },
                  child: const Text('80%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 90;
                  },
                  child: const Text('90%'))),
          const SizedBox(
            width: 10,
          ),
          Expanded(
              flex: 1,
              child: ElevatedButton(
                  onPressed: () {
                    controller.discountPercentage.value = 100;
                  },
                  child: const Text('100%'))),
        ]),
        Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          Obx(() => Text('Discount : ${controller.discountPercentage.value} %'))
        ]),
        Container(
          padding: const EdgeInsets.symmetric(horizontal: 10),
          child:
              Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
            Expanded(
                flex: 2,
                child: ElevatedButton(
                    style: ButtonStyle(
                        backgroundColor:
                            WidgetStateProperty.all<Color>(Colors.green)),
                    onPressed: () {
                      controller.submitDiscount(
                          typeToDiscount: typeToDiscount,
                          saleTableId: saleId,
                          saleDetailId: saleDetailId,
                          discountPercentage:
                              controller.discountPercentage.value);
                      Get.back();
                    },
                    child: const Text('Submit'))),
            const SizedBox(
              width: 10,
            ),
            Expanded(
                flex: 2,
                child: ElevatedButton(
                    style: ButtonStyle(
                        backgroundColor:
                            WidgetStateProperty.all<Color>(Colors.orange)),
                    onPressed: () {
                      Get.back();
                    },
                    child: const Text('Cancel'))),
          ]),
        ),
      ]),
    );
  }
}
