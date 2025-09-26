import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/response/food_dish_response.dart';
import 'package:chuanmapo_flutter/app/data/models/response/sale_table_response.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:collection/collection.dart';
import 'package:dio/dio.dart';

class OrderRepository extends ApiService {
  Future<FoodDishRespone> getAllFoodDish() async {
    final response =
        await get('food_dish', queryParameters: {'with_categories': true});
    return FoodDishRespone.fromJson(response.data);
  }

  Future<SaleTableResponse> getSaleTableAndSaleDetailByTableId(
      int? tableId, int? personCount) async {
    return await post('getSaleTableAndSaleDetailByTableId',
            data: {'dining_table_id': tableId, 'person_count': personCount})
        .then((value) => SaleTableResponse.fromJson(value.data))
        .catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> increaseQty(
      int saleDetailId, int diningTableId) async {
    return await post('increaseQty', data: {
      'sale_detail_id': saleDetailId,
      'dining_table_id': diningTableId
    }).then((value) => SaleTableResponse.fromJson(value.data)).catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> decreaseQty(
      int saleDetailId, int diningTableId, String? otpCode) async {
    return await post('decreaseQty', data: {
      'sale_detail_id': saleDetailId,
      'dining_table_id': diningTableId,
      'code': otpCode
    }).then((value) => SaleTableResponse.fromJson(value.data)).catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> changeQty(
      {required int saleDetailId,
      required int diningTableId,
      String? otpCode,
      required double changeQty}) async {
    return await post('changeQty', data: {
      'sale_detail_id': saleDetailId,
      'dining_table_id': diningTableId,
      'code': otpCode,
      'qty': changeQty
    }).then((value) => SaleTableResponse.fromJson(value.data)).catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> addSaleDetail({
    String? saleTableId,
    double? qty,
    double? foodPrice,
    double? discountPercentage,
    int? foodDishId,
    int? foodDishDetailId,
    int? diningTableId,
    //
    int? headId,
    int? tailId,
    int? wholeId,
    int? mixId,
    String? remark,
  }) async {
    return await post('addSaleDetail', data: {
      'sale_table_id': saleTableId,
      'qty': qty,
      'food_price': foodPrice,
      'discount_percentage': discountPercentage,
      'food_dish_id': foodDishId,
      'food_dish_detail_id': foodDishDetailId,
      'dining_table_id': diningTableId,
      //
      'head_id': headId,
      'tail_id': tailId,
      'whole_id': wholeId,
      'mix_id': mixId,
      'remark': remark,
    }).then((value) => SaleTableResponse.fromJson(value.data)).catchError((e) {
      if (e is DioException) {
        CommonWidget.toast(e.response?.data['message'] ?? '');
      }
    });
  }

  Future<String> generateDeletionCodeForSaleDetail(
      {required int saleDetailId}) async {
    return await post('generateDeletionCodeForSaleDetail',
        data: {'sale_detail_id': saleDetailId}).then((value) {
      return value.data['data'];
    }).catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> printNewItems(
      {required String? saleTableId}) async {
    return await post('print_new_items', data: {'sale_table_id': saleTableId})
        .then((value) {
      return SaleTableResponse.fromJson(value.data);
    }).catchError((e) {
      throw e;
    });
  }

  Future<SaleTableResponse> submitDiscount(
      {required int typeToDiscount,
      required double discountPercentage,
      String? saleTableId,
      int? saleDetailId,
      List? categoryIds}) async {
    switch (typeToDiscount) {
      case 1:
        print({
          'sale_table_id': saleTableId,
          'discount_percentage': discountPercentage
        });

        return await post('discountSale', data: {
          'sale_table_id': saleTableId,
          'discount_percentage': discountPercentage
        }).then((value) {
          return SaleTableResponse.fromJson(value.data);
        }).catchError((e) {
          throw e;
        });

      case 2:
        print({
          'sale_detail_id': saleDetailId,
          'discount_percentage': discountPercentage
        });
        return await post('discountSaleDetail', data: {
          'sale_detail_id': saleDetailId,
          'discount_percentage': discountPercentage
        }).then((value) {
          return SaleTableResponse.fromJson(value.data);
          // return value.data['data'];
        }).catchError((e) {
          throw e;
        });
      default:
        return await post('discountSaleDetailByCategory', data: {
          'sale_table_id': saleTableId,
          'category_ids': categoryIds,
          'discount_percentage': discountPercentage
        }).then((value) {
          return SaleTableResponse.fromJson(value.data);
        }).catchError((e) {
          throw e;
        });
    }
  }

  Future<Map<dynamic, List<Map<dynamic, dynamic>>>> getAnimalParts() async {
    return await get('animal-parts').then((value) {
      var a = groupBy(value.data['data'], (Map v) => v['type'])
          as Map<dynamic, List<Map<dynamic, dynamic>>>;
      print('===================');
      print(a);
      return a;
    }).catchError((e) {
      throw e;
    });
  }
}
