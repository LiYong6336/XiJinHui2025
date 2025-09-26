import 'dart:convert';

import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';

class SaleDetail {
  int? id;
  String? saleTableId;
  String? description;
  String? remark;
  double? qty;
  double? oldQty;
  double? foodPrice;
  double? totalAmount;
  double? discountPercentage;
  double? discountAmount;
  double? totalAmountAfterDiscount;
  int? foodDishId;
  int? foodDishDetailId;
  String? foodDishJson;
  String? foodDishDetailJson;
  String? createdAt;
  String? updatedAt;
  FoodDish? foodDishData;
  FoodDishDetail? foodDishDetailData;

  SaleDetail(
      {this.id,
      this.saleTableId,
      this.description,
      this.remark,
      this.qty,
      this.oldQty,
      this.foodPrice,
      this.totalAmount,
      this.discountPercentage,
      this.discountAmount,
      this.totalAmountAfterDiscount,
      this.foodDishId,
      this.foodDishDetailId,
      this.foodDishJson,
      this.foodDishDetailJson,
      this.createdAt,
      this.updatedAt});

  SaleDetail.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    saleTableId = json['sale_table_id'];
    description = json['description'];
    remark = json['remark'];
    qty = double.tryParse("${json['qty'] ?? '0'}");
    oldQty = double.tryParse("${json['old_qty'] ?? '0'}");
    foodPrice = double.tryParse("${json['food_price'] ?? '0'}");
    totalAmount = double.tryParse("${json['total_amount'] ?? '0'}");
    discountPercentage =
        double.tryParse("${json['discount_percentage'] ?? '0'}");
    discountAmount = double.tryParse("${json['discount_amount'] ?? '0'}");
    totalAmountAfterDiscount =
        double.tryParse("${json['total_amount_after_discount'] ?? '0'}");
    foodDishId = json['food_dish_id'];
    foodDishDetailId = json['food_dish_detail_id'];
    foodDishJson = json['food_dish_json'];
    foodDishDetailJson = json['food_dish_detail_json'];
    createdAt = json['created_at'];
    updatedAt = json['updated_at'];

    foodDishData = json['food_dish_json'] != null
        ? FoodDish.fromJson(jsonDecode(json['food_dish_json']))
        : null;
    foodDishDetailData = json['food_dish_detail_json'] != null
        ? FoodDishDetail.fromJson(jsonDecode(json['food_dish_detail_json']))
        : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['sale_table_id'] = saleTableId;
    data['description'] = description;
    data['remark'] = remark;
    data['qty'] = qty;
    data['old_qty'] = oldQty;
    data['food_price'] = foodPrice;
    data['total_amount'] = totalAmount;
    data['discount_percentage'] = discountPercentage;
    data['discount_amount'] = discountAmount;
    data['total_amount_after_discount'] = totalAmountAfterDiscount;
    data['food_dish_id'] = foodDishId;
    data['food_dish_detail_id'] = foodDishDetailId;
    data['food_dish_json'] = foodDishJson;
    data['food_dish_detail_json'] = foodDishDetailJson;
    data['created_at'] = createdAt;
    data['updated_at'] = updatedAt;
    return data;
  }

  String getFullDescription() {
    var str = foodDishData?.getFullName() ?? '';
    if (foodDishDetailData != null) {
      //str = str + " ("+ GeneralFunction.GetPropertyValue(this.FoodDishDetail ) +")";
      str = "$str (${foodDishDetailData?.getFullName() ?? ''})";
    }
    if (remark != null && remark != "") {
      str = "$str ($remark)";
    }
    return str;
  }
}
