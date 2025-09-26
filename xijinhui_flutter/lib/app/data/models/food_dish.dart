import 'package:chuanmapo_flutter/app/data/models/category_model.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';

class FoodDish {
  int? id;
  int? categoryId;
  String? foodCode;
  String? englishName;
  String? chineseName;
  String? khmerName;
  String? description;
  double? foodPrice;
  String? remark;
  String? foodPhoto;
  String? foodPhotoUrl;
  String? englishKeyword;
  String? chineseKeyword;
  String? khmerKeyword;
  int? displayOrder;
  bool? isEnable;
  List<FoodDishDetail>? foodDishDetails;
  CategoryModel? category;

  FoodDish({
    this.id,
    this.categoryId,
    this.foodCode,
    this.englishName,
    this.chineseName,
    this.khmerName,
    this.description,
    this.foodPrice,
    this.remark,
    this.foodPhoto,
    this.foodPhotoUrl,
    this.englishKeyword,
    this.chineseKeyword,
    this.khmerKeyword,
    this.displayOrder,
    this.isEnable,
    this.foodDishDetails,
    this.category,
  });

  FoodDish.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    categoryId = json['category_id'];
    foodCode = json['food_code'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    description = json['description'];
    foodPrice = double.tryParse('${json['food_price']}');
    remark = json['remark'];
    foodPhoto = json['food_photo'];
    foodPhotoUrl = json['food_photo_url'];
    englishKeyword = json['english_keyword'];
    chineseKeyword = json['chinese_keyword'];
    khmerKeyword = json['khmer_keyword'];
    displayOrder = int.tryParse('${json['display_order']}');
    isEnable = bool.tryParse('${json['is_enable']}');
    if (json['category'] != null) {
      category = CategoryModel.fromJson(json['category']);
    }

    if (json['food_dish_details'] != null) {
      foodDishDetails = <FoodDishDetail>[];
      json['food_dish_details'].forEach((v) {
        foodDishDetails!.add(FoodDishDetail.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['category_id'] = categoryId;
    data['food_code'] = foodCode;
    data['english_name'] = englishName;
    data['chinese_name'] = chineseName;
    data['khmer_name'] = khmerName;
    data['description'] = description;
    data['food_price'] = foodPrice;
    data['remark'] = remark;
    data['food_photo'] = foodPhoto;
    data['food_photo_url'] = foodPhotoUrl;
    data['english_keyword'] = englishKeyword;
    data['chinese_keyword'] = chineseKeyword;
    data['khmer_keyword'] = khmerKeyword;
    data['display_order'] = displayOrder;
    data['is_enable'] = isEnable;
    data['is_enable'] = isEnable;
    if (foodDishDetails != null) {
      data['food_dish_details'] =
          foodDishDetails!.map((v) => v.toJson()).toList();
    }
    if (category != null) {
      data['category'] = category?.toJson();
    }
    return data;
  }

  String getFullName() {
    var l = [englishName, chineseName, khmerName];
    return l.where((e) => e != null).toList().join(' - ');
  }
}
