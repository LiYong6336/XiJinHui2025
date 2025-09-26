import 'package:chuanmapo_flutter/app/data/api/repository/payment_method_repository.dart';
import 'package:chuanmapo_flutter/app/data/models/response/payment_method_response.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:get/get.dart';

class PaymentMethodController extends GetxController {
  PaymentMethodRepository paymentMethodRepository = PaymentMethodRepository();
  var paymentMethods = RxList<PaymentMethod>();

  @override
  void onReady() {
    getAllPaymentMethods();
    super.onReady();
  }

  Future getAllPaymentMethods() async {
    try {
      final res = await paymentMethodRepository.payment_methods();
      paymentMethods.value = res.data!;
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }
}
