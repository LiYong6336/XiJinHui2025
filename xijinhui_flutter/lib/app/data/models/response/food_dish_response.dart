import 'package:chuanmapo_flutter/app/data/models/category_model.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';

class FoodDishRespone {
  bool? success;
  String? message;
  List<FoodDish>? foodDish;
  List<CategoryModel>? categories;

  FoodDishRespone({this.success, this.message, this.foodDish, this.categories});

  FoodDishRespone.fromJson(Map<String, dynamic> json) {
    success = json['success'];
    message = json['message'];
    if (json['data'] != null) {
      final data = json['data'];
      if (data['food_dish'] != null) {
        foodDish = <FoodDish>[];
        data['food_dish'].forEach((v) {
          foodDish!.add(FoodDish.fromJson(v));
        });
      }
      if (data['categories'] != null) {
        categories = <CategoryModel>[];
        data['categories'].forEach((v) {
          categories!.add(CategoryModel.fromJson(v));
        });
      }
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['success'] = success;
    data['message'] = message;
    if (foodDish != null && categories != null) {
      data['data'] = {
        'food_dish': foodDish!.map((v) => v.toJson()).toList(),
        'categories': categories!.map((v) => v.toJson()).toList(),
      };
    }
    return data;
  }
}
