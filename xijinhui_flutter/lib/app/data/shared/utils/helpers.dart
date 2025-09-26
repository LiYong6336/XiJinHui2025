import 'package:chuanmapo_flutter/app/data/api/api_constants.dart';
import 'package:get/get.dart';
import 'package:shared_preferences/shared_preferences.dart';

String getApiUrl() {
  final prefs = Get.find<SharedPreferences>();

  var url =
      prefs.getString(prefs.getString('UsingServer') ?? 'OnlineServer') ?? '';
  url = url == '' ? ApiConstants.baseUrl : url;
  ApiConstants.baseUrl = url + (url.endsWith('/') ? 'api/' : '/api/');
  return ApiConstants.baseUrl;
}
