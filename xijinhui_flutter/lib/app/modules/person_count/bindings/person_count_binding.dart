import 'package:get/get.dart';

import '../controllers/person_count_controller.dart';

class PersonCountBinding extends Bindings {
  @override
  void dependencies() {
    Get.put<PersonCountController>(
      PersonCountController(dining_table_id: 0),
    );
  }
}
