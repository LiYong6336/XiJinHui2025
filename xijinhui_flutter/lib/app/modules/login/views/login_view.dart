import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';

import 'package:get/get.dart';

import '../controllers/login_controller.dart';

class LoginView extends GetView<LoginController> {
  const LoginView({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        padding: const EdgeInsets.only(top: 50, left: 20, right: 20),
        child: Form(
          key: controller.loginFormKey,
          child: SingleChildScrollView(
            child: Column(children: [
              const CircleAvatar(
                radius: 150,
                backgroundImage: AssetImage('assets/icons/logo.png'),
              ),
              const SizedBox(height: 30.0),
              TextField(
                controller: controller.emailController,
                decoration: InputDecoration(
                  isDense: true,
                  prefixIcon: const Icon(Icons.email),
                  suffixIcon: IconButton(
                      icon: const Icon(Icons.clear),
                      onPressed: () {
                        controller.emailController.clear();
                      }),
                  hintText: 'Enter your email',
                ),
              ),
              const SizedBox(height: 30.0),
              Obx(() => TextField(
                    controller: controller.passwordController,
                    obscureText: controller.isOpen.value,
                    decoration: InputDecoration(
                      isDense: true,
                      prefixIcon: const Icon(Icons.lock),
                      suffixIcon: IconButton(
                          icon: controller.isOpen.value
                              ? const Icon(Icons.visibility)
                              : const Icon(Icons.visibility_off),
                          onPressed: controller.changeEyeValue),
                      hintText: 'Enter your password',
                    ),
                  )),
              const SizedBox(height: 30.0),
              ElevatedButton(
                style: ElevatedButton.styleFrom(
                  minimumSize: const Size.fromHeight(50), // NEW
                ),
                onPressed: () async {
                  await controller.login(context);
                },
                child: const Text('Login'),
              ),
              const SizedBox(height: 30.0),
              const Divider(
                height: 3.0,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  IconButton(
                    onPressed: () {},
                    icon: SvgPicture.asset('assets/svg/us.svg'),
                  ),
                  IconButton(
                    onPressed: () {},
                    icon: SvgPicture.asset('assets/svg/kh.svg'),
                  ),
                  IconButton(
                    onPressed: () {},
                    icon: SvgPicture.asset('assets/svg/cn.svg'),
                  )
                ],
              ),
              Obx(() => Text('Version: ${controller.version.value}')),
              const SizedBox(height: 10),
              IconButton(
                icon: const Icon(Icons.settings),
                onPressed: _buildSwitchServerDialog,
              ),
            ]),
          ),
        ),
      ),
    );
  }

  _buildSwitchServerDialog() {
    Get.dialog(
      Dialog(
        child: Container(
          padding: EdgeInsets.all(20),
          child: Obx(
            () => Column(
              mainAxisSize: MainAxisSize.min,
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text('Switch server', style: TextStyle(fontSize: 24)),
                const SizedBox(height: 10.0),
                Text('Online Server'),
                Row(
                  children: [
                    Expanded(
                        child: TextField(
                      controller: controller.onlineServerController,
                    )),
                    Radio(
                      value: "OnlineServer",
                      groupValue: controller.usingServer.value,
                      onChanged: (value) {
                        controller.usingServer.value = value.toString();
                      },
                    ),
                  ],
                ),
                const SizedBox(height: 10.0),
                Text('Local Server'),
                Row(
                  children: [
                    Expanded(
                        child: TextField(
                      controller: controller.localServerController,
                    )),
                    Radio(
                      value: 'LocalServer',
                      groupValue: controller.usingServer.value,
                      onChanged: (value) {
                        controller.usingServer.value = value.toString();
                      },
                    ),
                  ],
                ),
                const SizedBox(height: 10.0),
                Row(
                  children: [
                    Spacer(),
                    ElevatedButton(
                        onPressed: () {
                          controller.saveDataToServerSwitcher();
                          Get.back();
                        },
                        child: Text('Save')),
                    Spacer(),
                  ],
                )
              ],
            ),
          ),
        ),
      ),
    );
  }
}
