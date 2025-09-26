import 'package:get/get.dart';

import '../controllers/order_menu_controller.dart';

class OrderMenuBinding extends Bindings {
  @override
  void dependencies() {
    Get.lazyPut<OrderMenuController>(
      () => OrderMenuController(),
    );
  }
}
