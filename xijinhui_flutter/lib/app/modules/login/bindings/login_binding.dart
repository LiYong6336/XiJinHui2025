import 'package:chuanmapo_flutter/app/data/api/repository/auth_repository.dart';
import 'package:get/get.dart';

import '../controllers/login_controller.dart';

class LoginBinding extends Bindings {
  @override
  void dependencies() {
    Get.put<LoginController>(
      LoginController(authRepository: AuthRepository()),
    );
  }
}
