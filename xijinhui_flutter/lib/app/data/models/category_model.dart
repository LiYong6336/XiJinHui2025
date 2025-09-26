import 'package:chuanmapo_flutter/app/data/shared/services/printer_service.dart';

class CategoryModel {
  int? id;
  String? categoryCode;
  String? englishName;
  String? chineseName;
  String? khmerName;
  String? remark;
  String? categoryPhoto;
  int? printerId;
  bool? isDrink;
  bool? isAnimalPart;
  PrinterModel? printer;

  CategoryModel({
    this.id,
    this.categoryCode,
    this.englishName,
    this.chineseName,
    this.khmerName,
    this.remark,
    this.categoryPhoto,
    this.printerId,
    this.printer,
    this.isDrink,
    this.isAnimalPart,
  });

  CategoryModel.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    categoryCode = json['category_code'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    remark = json['remark'];
    categoryPhoto = json['category_photo'];
    printerId = json['printer_id'];
    isDrink = json['is_drink'];
    isAnimalPart = json['is_animal_part'];
    printer =
        json['printer'] != null ? PrinterModel.fromJson(json['printer']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['category_code'] = categoryCode;
    data['english_name'] = englishName;
    data['chinese_name'] = chineseName;
    data['khmer_name'] = khmerName;
    data['remark'] = remark;
    data['category_photo'] = categoryPhoto;
    data['printer_id'] = printerId;
    data['is_drink'] = isDrink;
    data['is_animal_part'] = isAnimalPart;
    if (printer != null) {
      data['printer'] = printer!.toJson();
    }
    return data;
  }
}
