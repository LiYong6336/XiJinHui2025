import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../controllers/payment_method_controller.dart';

class PaymentMethodView extends GetView<PaymentMethodController> {
  const PaymentMethodView({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('PaymentMethodView'),
          centerTitle: true,
        ),
        body: Column(
          children: [
            Expanded(
                child: ListView.builder(
                    itemCount: controller.paymentMethods.length,
                    itemBuilder: (context, index) {
                      return ListTile(
                        title:
                            Text(controller.paymentMethods[index].englishName!),
                        onTap: () {
                          Get.back(result: controller.paymentMethods[index]);
                        },
                      );
                    })),
          ],
        ));
  }
}
