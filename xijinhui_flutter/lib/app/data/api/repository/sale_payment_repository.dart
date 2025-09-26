import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/response/sale_table_response.dart';

class SalePaymentRepository extends ApiService {
  Future<SaleTableResponse> submitPayment(
      {required String saleTableId, required List<Map> payments}) async {
    final response = await post(
      'salePayment',
      data: {
        'sale_table_id': saleTableId,
        'payments': payments,
      },
    );
    return SaleTableResponse.fromJson(response.data);
  }
}
