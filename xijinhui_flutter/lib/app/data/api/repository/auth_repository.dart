import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/response/login_response.dart';

class AuthRepository extends ApiService {
  Future<LoginResponse?> login(String phone, String password) async {
    return await post('login', data: {'phone': phone, 'password': password})
        .then((value) {
      return LoginResponse.fromJson(value.data);
    }).catchError((err) {
      throw err;
    });
  }

  Future logout() async {
    post('logout', data: {});
    // SharedPreferences prefs = await SharedPreferences.getInstance();
    // await prefs.clear();
  }
}
