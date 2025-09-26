import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:get/get.dart';

class AppBinding extends Bindings {
  @override
  void dependencies() async {
    Get.put(ApiService(), permanent: true);
  }
}
