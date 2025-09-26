import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/response/dining_table_response.dart';

class DiningTableRepository extends ApiService {
  Future<DiningTableResponse?> get_dining_table() async {
    final res = await get('dining_table');

    if (res.statusCode == 200) {
      return DiningTableResponse.fromJson(res.data);
    }

    return null;
  }

  Future<bool> logout() async {
    final res = await post('logout');

    if (res.statusCode == 200) {
      return true;
    }

    return false;
  }
}
