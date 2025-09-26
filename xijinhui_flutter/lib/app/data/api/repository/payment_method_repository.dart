import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/response/payment_method_response.dart';

class PaymentMethodRepository extends ApiService {
  Future<PaymentMethodResponse> payment_methods() async {
    final response = await get(
      'payment_methods',
    );
    return PaymentMethodResponse.fromJson(response.data);
  }
}
