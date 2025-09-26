class FoodDishDetail {
  int? id;
  String? englishName;
  String? chineseName;
  String? khmerName;
  double? price;
  int? foodDishId;
  String? createdAt;
  String? updatedAt;

  FoodDishDetail(
      {this.id,
      this.englishName,
      this.chineseName,
      this.khmerName,
      this.price,
      this.foodDishId,
      this.createdAt,
      this.updatedAt});

  FoodDishDetail.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    price = double.tryParse('${json['price'] ?? '0'}');
    foodDishId = json['food_dish_id'];
    createdAt = json['created_at'];
    updatedAt = json['updated_at'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['english_name'] = englishName;
    data['chinese_name'] = chineseName;
    data['khmer_name'] = khmerName;
    data['price'] = price;
    data['food_dish_id'] = foodDishId;
    data['created_at'] = createdAt;
    data['updated_at'] = updatedAt;
    return data;
  }

  String getFullName() {
    var l = [englishName, chineseName, khmerName];
    return l.where((e) => e != null).toList().join(' - ');
  }
}
