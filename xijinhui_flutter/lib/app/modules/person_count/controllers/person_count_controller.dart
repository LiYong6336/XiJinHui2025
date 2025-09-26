import 'package:get/get.dart';

class PersonCountController extends GetxController {
  final int dining_table_id;
  PersonCountController({required this.dining_table_id});

  Map<String, dynamic> args() {
    return {
      'tableid': dining_table_id,
      'personCount': personCount.value,
    };
  }

  var personCount = 0.obs;
  var isDelivery = false.obs;
}
