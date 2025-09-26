import 'dart:convert';

import 'package:chuanmapo_flutter/app/data/api/repository/auth_repository.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/routes/app_pages.dart';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:package_info_plus/package_info_plus.dart';
import 'package:shared_preferences/shared_preferences.dart';

class LoginController extends GetxController {
  final AuthRepository authRepository;
  LoginController({required this.authRepository});
  final GlobalKey<FormState> loginFormKey = GlobalKey<FormState>();

  final emailController = TextEditingController();
  final passwordController = TextEditingController();
  final isOpen = true.obs;
  var version = ''.obs;

  var usingServer = 'OnlineServer'.obs;
  var onlineServerController = TextEditingController();
  var localServerController = TextEditingController();

  @override
  void onInit() async {
    PackageInfo packageInfo = await PackageInfo.fromPlatform();
    version.value = packageInfo.version;

    bindDataToServerSwitcher();

    super.onInit();
  }

  void bindDataToServerSwitcher() {
    final prefs = Get.find<SharedPreferences>();
    onlineServerController.text = prefs.getString('OnlineServer') ?? '';
    localServerController.text = prefs.getString('LocalServer') ?? '';
    usingServer.value = prefs.getString('UsingServer') ?? 'OnlineServer';
  }

  bool changeEyeValue() {
    isOpen.value = !isOpen.value;
    return isOpen.value;
  }

  void saveDataToServerSwitcher() {
    final prefs = Get.find<SharedPreferences>();
    prefs.setString('OnlineServer', onlineServerController.text);
    prefs.setString('LocalServer', localServerController.text);
    prefs.setString('UsingServer', usingServer.value);
  }

  Future login(BuildContext context) async {
    AppFocus.unfocus(context);
    if (loginFormKey.currentState!.validate()) {
      try {
        final res = await authRepository.login(
          emailController.text,
          passwordController.text,
        );
        final prefs = Get.find<SharedPreferences>();
        if (res!.data!.token!.isNotEmpty) {
          prefs.setString('token', res.data?.token ?? '');
          prefs.setString('user', jsonEncode(res.data?.user?.toJson() ?? {}));
          Get.offAllNamed(Routes.HOME);
        }
      } catch (e) {
        if (e is DioException) {
          // CommonWidget.toast(
          //     e.response?.data['message'] ?? 'Can Not Connect Server');
          CommonWidget.toast(e.toString());
        }
      }
    }
  }
}
