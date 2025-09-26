import 'package:chuanmapo_flutter/app/data/models/response/payment_method_response.dart';
import 'package:chuanmapo_flutter/app/modules/payment_method/views/payment_method_view.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../controllers/sale_payment_controller.dart';

class SalePaymentView extends GetView<SalePaymentController> {
  const SalePaymentView({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Payment'),
        centerTitle: true,
        actions: [
          IconButton(
              onPressed: () {
                controller.submitPayment(1);
              },
              icon: const Icon(Icons.print))
        ],
      ),
      body: Container(
        padding: const EdgeInsets.all(10),
        child: Column(mainAxisAlignment: MainAxisAlignment.start, children: [
          const Row(
            children: [
              Expanded(
                  child: Text('Payment Dollar',
                      style: TextStyle(
                          fontSize: 14, fontWeight: FontWeight.bold))),
              Expanded(
                  child: Text('Payment Riels',
                      style: TextStyle(
                          fontSize: 14, fontWeight: FontWeight.bold))),
            ],
          ),
          Row(
            children: [
              Expanded(
                child: Obx(
                  () => Text(
                    controller.textPaymentDollar.value,
                    style: const TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                        color: Colors.blue),
                  ),
                ),
              ),
              Expanded(
                child: Obx(
                  () => Text(
                    controller.textPaymentRiels.value,
                    style: const TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                        color: Colors.blue),
                  ),
                ),
              ),
            ],
          ),
          const Row(
            children: [
              Expanded(
                  child: Text('Change Dollar',
                      style: TextStyle(
                          fontSize: 14, fontWeight: FontWeight.bold))),
              Expanded(
                  child: Text('Change Riels',
                      style: TextStyle(
                          fontSize: 14, fontWeight: FontWeight.bold))),
            ],
          ),
          Row(
            children: [
              Expanded(
                child: Obx(
                  () => Text(
                    controller.textChangeDollar.value,
                    style: const TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                        color: Colors.red),
                  ),
                ),
              ),
              Expanded(
                child: Obx(
                  () => Text(
                    controller.textChangeRiels.value,
                    style: const TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                        color: Colors.red),
                  ),
                ),
              ),
            ],
          ),
          Row(
            children: [
              const Expanded(
                  child: Text('Payment Method',
                      style: TextStyle(
                          fontSize: 14, fontWeight: FontWeight.bold))),
              Expanded(
                  child: IconButton(
                      onPressed: () async {
                        PaymentMethod result =
                            await Get.dialog(const PaymentMethodView());
                        controller.addPaymentMethod(result);
                      },
                      icon: const Icon(Icons.add_circle_outline))),
            ],
          ),
          Obx(
            () => Expanded(
                child: ListView.builder(
                    itemCount: controller.selectedPaymentMentods.length,
                    itemBuilder: (context, index) {
                      return _buildPaymentMethod(
                          controller.selectedPaymentMentods[index]);
                    })),
          ),
        ]),
      ),
    );
  }

  _buildPaymentMethod(PaymentMethod paymentMethod) {
    return Container(
      margin: const EdgeInsets.only(bottom: 15),
      child: Row(
        children: [
          Expanded(
              child: TextFormField(
            keyboardType: TextInputType.number,
            controller: controller.textReceiveDollarsMap[paymentMethod.id!],
            onChanged: (value) {
              controller.calculateChange();
            },
            decoration: InputDecoration(
              isDense: true,
              labelText: "${paymentMethod.englishName}(USD)",
            ),
          )),
          Expanded(
              child: TextFormField(
            keyboardType: TextInputType.number,
            controller: controller.textReceiveRielsMap[paymentMethod.id!],
            onChanged: (value) {
              controller.calculateChange();
            },
            decoration: InputDecoration(
              isDense: true,
              labelText: "${paymentMethod.englishName}(RIEL)",
            ),
          )),
          IconButton(
              onPressed: () {
                controller.selectedPaymentMentods.remove(paymentMethod);
                controller.textReceiveDollarsMap.remove(paymentMethod.id);
                controller.textReceiveRielsMap.remove(paymentMethod.id);
              },
              icon: const Icon(
                Icons.delete,
                color: Colors.red,
              ))
        ],
      ),
    );
  }
}
