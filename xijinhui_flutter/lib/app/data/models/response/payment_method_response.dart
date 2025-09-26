class PaymentMethodResponse {
  bool? success;
  String? message;
  List<PaymentMethod>? data;

  PaymentMethodResponse({this.success, this.message, this.data});

  PaymentMethodResponse.fromJson(Map<String, dynamic> json) {
    success = json['success'];
    message = json['message'];
    if (json['data'] != null) {
      data = <PaymentMethod>[];
      json['data'].forEach((v) {
        data!.add(PaymentMethod.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['success'] = success;
    data['message'] = message;
    if (this.data != null) {
      data['data'] = this.data!.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

class PaymentMethod {
  int? id;
  String? paymentCode;
  String? englishName;
  String? chineseName;
  String? khmerName;
  String? paymentUrl;

  PaymentMethod(
      {this.id,
      this.paymentCode,
      this.englishName,
      this.chineseName,
      this.khmerName,
      this.paymentUrl});

  PaymentMethod.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    paymentCode = json['payment_code'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    paymentUrl = json['payment_url'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['payment_code'] = paymentCode;
    data['english_name'] = englishName;
    data['chinese_name'] = chineseName;
    data['khmer_name'] = khmerName;
    data['payment_url'] = paymentUrl;
    return data;
  }
}
