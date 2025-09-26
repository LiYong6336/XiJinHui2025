import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:get/get.dart';

class QtyChanger extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  SaleDetail saleDetail;
  QtyChanger({
    super.key,
    required this.saleDetail,
  });

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisSize: MainAxisSize.min,
      children: [
        IconButton(
          padding: EdgeInsets.zero,
          onPressed: () async {
            if ((controller.saleTable.value?.preReceiptPrintTime ?? 0) > 0) {
              await controller.generateDeletionCodeForSaleDetail(
                saleDetailId: saleDetail.id ?? 0,
              );

              Get.defaultDialog(
                title: controller.generatedOpt.value.toString(),
                content: TextField(
                  controller: controller.textOtpController,
                  keyboardType: TextInputType.number,
                  decoration: InputDecoration(
                    isDense: true,
                    prefixIcon: const Icon(Icons.lock),
                    suffixIcon: IconButton(
                        icon: const Icon(Icons.clear),
                        onPressed: () {
                          controller.textOtpController.clear();
                        }),
                    hintText: 'Enter your otp',
                  ),
                ),
                // backgroundColor: Colors.teal,
                radius: 30,
                cancel: ElevatedButton(
                    onPressed: () {
                      Clipboard.setData(
                        ClipboardData(text: controller.generatedOpt.value),
                      );
                    },
                    child: const Text('Copy')),
                confirm: ElevatedButton(
                  onPressed: () {
                    controller.decreaseQty(
                        saleDetailId: saleDetail.id!,
                        diningTableId:
                            controller.saleTable.value?.diningTableId ?? 0,
                        otpCode: controller.textOtpController.text);
                  },
                  child: const Text('confirm'),
                ),
              );
            } else {
              controller.decreaseQty(
                  saleDetailId: saleDetail.id!,
                  diningTableId:
                      controller.saleTable.value?.diningTableId ?? 0);
            }
          },
          icon: const Icon(Icons.remove_circle_outline),
        ),
        InkWell(
          onTap: () async {
            controller.textChangedQtyController.text =
                (saleDetail.qty ?? 0.0).toString();
            controller.compareChangedQty.value = (saleDetail.qty ?? 0.0);
            controller.isShowContainer.value = false;

            Get.defaultDialog(
              title: '',
              content: Obx(() => Column(
                    children: [
                      TextField(
                        controller: controller.textChangedQtyController,
                        keyboardType: TextInputType.number,
                        decoration: InputDecoration(
                          isDense: true,
                          prefixIcon: IconButton(
                            icon: const Icon(Icons.check),
                            onPressed: () {
                              controller.textOtpController.clear();
                              controller.isShowContainer.value =
                                  (controller.compareChangedQty.value >
                                      (double.tryParse(controller
                                              .textChangedQtyController.text) ??
                                          0));
                              if (controller.isShowContainer.value) {
                                controller.generateDeletionCodeForSaleDetail(
                                  saleDetailId: saleDetail.id ?? 0,
                                );
                              } else {
                                controller.changeQty(
                                    saleDetailId: saleDetail.id ?? 0,
                                    diningTableId: controller
                                            .saleTable.value?.diningTableId ??
                                        0,
                                    changeQty: double.tryParse(controller
                                            .textChangedQtyController.text) ??
                                        0.0);
                                Get.back();
                              }
                            },
                          ),
                          label: const Text('Qty'),
                          suffixIcon: IconButton(
                              icon: const Icon(Icons.clear),
                              onPressed: () {
                                controller.textChangedQtyController.clear();
                              }),
                        ),
                      ),
                      controller.isShowContainer.value
                          ? Container(
                              child: Column(
                                children: [
                                  Text(
                                      controller.generatedOpt.value.toString()),
                                  TextField(
                                    controller: controller.textOtpController,
                                    keyboardType: TextInputType.number,
                                    decoration: InputDecoration(
                                      isDense: true,
                                      prefixIcon: const Icon(Icons.lock),
                                      suffixIcon: IconButton(
                                          icon: const Icon(Icons.clear),
                                          onPressed: () {
                                            controller.textOtpController
                                                .clear();
                                          }),
                                      hintText: 'Enter your otp',
                                    ),
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.center,
                                    children: [
                                      ElevatedButton(
                                        onPressed: () {
                                          Clipboard.setData(
                                            ClipboardData(
                                                text: controller
                                                    .generatedOpt.value),
                                          );
                                        },
                                        child: const Text('Copy'),
                                      ),
                                      ElevatedButton(
                                        onPressed: () {
                                          controller.changeQty(
                                              saleDetailId: saleDetail.id!,
                                              diningTableId: controller
                                                      .saleTable
                                                      .value
                                                      ?.diningTableId ??
                                                  0,
                                              otpCode: controller
                                                  .textOtpController.text,
                                              changeQty: double.tryParse(controller
                                                      .textChangedQtyController
                                                      .text) ??
                                                  0.0);
                                          Get.back();
                                        },
                                        child: const Text('confirm'),
                                      )
                                    ],
                                  )
                                ],
                              ),
                            )
                          : Container(),
                    ],
                  )),
              // backgroundColor: Colors.teal,
            );
          },
          child: Text(
            saleDetail.qty.toString(),
          ),
        ),
        IconButton(
          onPressed: () {
            controller.increaseQty(
              saleDetailId: saleDetail.id!,
              diningTableId: controller.saleTable.value!.diningTableId!,
            );
          },
          icon: const Icon(Icons.add_circle_outline),
        ),
      ],
    );
  }
}
