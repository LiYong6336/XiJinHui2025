import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';

class SaleTableResponse {
  bool? success;
  String? message;
  SaleTable? data;

  SaleTableResponse({this.success, this.message, this.data});

  SaleTableResponse.fromJson(Map<String, dynamic> json) {
    success = json['success'];
    message = json['message'];
    data = json['data'] != null ? SaleTable.fromJson(json['data']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['success'] = success;
    data['message'] = message;
    if (this.data != null) {
      data['data'] = this.data!.toJson();
    }
    return data;
  }
}
