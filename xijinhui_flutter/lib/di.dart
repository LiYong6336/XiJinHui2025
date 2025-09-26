import 'package:chuanmapo_flutter/app/data/shared/services/storage_service.dart';
import 'package:get/get.dart';

class DenpendencyInjection {
  static Future<void> init() async {
    await Get.putAsync(() => StorageService().init());
  }
}
