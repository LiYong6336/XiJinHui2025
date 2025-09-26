import 'package:chuanmapo_flutter/app/data/api/repository/dining_table_repository.dart';
import 'package:get/get.dart';

import '../controllers/home_controller.dart';

class HomeBinding extends Bindings {
  @override
  void dependencies() {
    Get.put<HomeController>(
      HomeController(
        diningTableRepository: DiningTableRepository(),
      ),
    );
  }
}
