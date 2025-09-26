import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get_state_manager/src/simple/get_view.dart';

class CategotyDiscount extends GetView<OrderMenuController> {
  const CategotyDiscount({super.key});

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 200,
      child: SingleChildScrollView(
        child:
            Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          for (var item = 0; item < controller.categories.length; item++)
            const Expanded(
              flex: 1,
              child: Text('worked'),
            ),
        ]),
      ),
    );
  }
}
