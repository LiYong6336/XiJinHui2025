import 'package:get/get.dart';

import '../modules/home/bindings/home_binding.dart';
import '../modules/home/views/home_view.dart';
import '../modules/login/bindings/login_binding.dart';
import '../modules/login/views/login_view.dart';
import '../modules/order_menu/bindings/order_menu_binding.dart';
import '../modules/order_menu/views/order_menu_view.dart';
import '../modules/payment_method/bindings/payment_method_binding.dart';
import '../modules/payment_method/views/payment_method_view.dart';
import '../modules/person_count/bindings/person_count_binding.dart';
import '../modules/person_count/views/person_count_view.dart';
import '../modules/sale_payment/bindings/sale_payment_binding.dart';
import '../modules/sale_payment/views/sale_payment_view.dart';
import '../modules/splash/bindings/splash_binding.dart';
import '../modules/splash/views/splash_view.dart';

part 'app_routes.dart';

class AppPages {
  AppPages._();

  static const INITIAL = Routes.SPLASH;

  static final routes = [
    GetPage(
      name: _Paths.HOME,
      page: () => const HomeView(),
      binding: HomeBinding(),
    ),
    GetPage(
      name: _Paths.LOGIN,
      page: () => const LoginView(),
      binding: LoginBinding(),
    ),
    GetPage(
      name: _Paths.SPLASH,
      page: () => const SplashView(),
      binding: SplashBinding(),
    ),
    GetPage(
      name: _Paths.PERSON_COUNT,
      page: () => const PersonCountView(),
      binding: PersonCountBinding(),
    ),
    GetPage(
      name: _Paths.ORDER_MENU,
      page: () => const OrderMenuView(),
      binding: OrderMenuBinding(),
    ),
    GetPage(
      name: _Paths.SALE_PAYMENT,
      page: () => const SalePaymentView(),
      binding: SalePaymentBinding(),
    ),
    GetPage(
      name: _Paths.PAYMENT_METHOD,
      page: () => const PaymentMethodView(),
      binding: PaymentMethodBinding(),
    ),
  ];
}
