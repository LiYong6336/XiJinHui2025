import 'package:chuanmapo_flutter/app_binding.dart';
import 'package:chuanmapo_flutter/di.dart';
import 'package:flutter/material.dart';
import 'package:flutter_easyloading/flutter_easyloading.dart';
import 'package:get/get.dart';
import 'app/routes/app_pages.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await DenpendencyInjection.init();
  runApp(
    GetMaterialApp(
        title: "Restaurant",
        initialRoute: AppPages.INITIAL,
        getPages: AppPages.routes,
        debugShowCheckedModeBanner: false,
        enableLog: true,
        defaultTransition: Transition.fade,
        initialBinding: AppBinding(),
        smartManagement: SmartManagement.keepFactory,
        // locale: TranslationService.locale,
        // fallbackLocale: TranslationService.fallbackLocale,
        // translations: TranslationService(),
        builder: EasyLoading.init(),
        theme: ThemeData(
          appBarTheme: const AppBarTheme(
            // backgroundColor: Colors.red,
            elevation: 10,
            iconTheme: IconThemeData(color: Colors.white),
          ),
          primarySwatch: Colors.red,
          // Define the default font family.
          fontFamily: 'Harmonyos Sans',
          useMaterial3: false,
          // Define the default `InputDecoration` border.
          inputDecorationTheme: const InputDecorationTheme(
            border: OutlineInputBorder(),
          ),
        )),
  );
}
