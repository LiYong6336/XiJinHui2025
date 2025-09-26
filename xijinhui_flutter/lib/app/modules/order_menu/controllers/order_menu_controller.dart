import 'dart:convert';

import 'package:chuanmapo_flutter/app/data/api/repository/printer_repository.dart';
import 'package:chuanmapo_flutter/app/data/models/category_model.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/response/login_response.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';
import 'package:chuanmapo_flutter/app/data/shared/reports/report_food_for_kichen.dart';
import 'package:chuanmapo_flutter/app/data/shared/reports/report_print_receipt.dart';
import 'package:chuanmapo_flutter/app/data/api/repository/order_repository.dart';
import 'package:chuanmapo_flutter/app/data/shared/services/printer_service.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:collection/collection.dart';
import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:get/get.dart';
import 'package:shared_preferences/shared_preferences.dart';

class OrderMenuController extends GetxController {
  OrderMenuController({this.tableId, this.personCount});
  var orderRepository = OrderRepository();
  var printerRepository = PrinterRepository();

  var textOtpController = TextEditingController();
  var textChangedQtyController = TextEditingController();
  var compareChangedQty = 0.0.obs;
  var isShowContainer = false.obs;
  var printers = RxList<PrinterModel>();

  var generatedOpt = ''.obs;
  var discountPercentage = 0.0.obs;
  Map<String, TextEditingController> textEditingControllerMap = {};

  var selectedIndex = 0.obs;

  final int? tableId;
  final int? personCount;

  var tempQTY = 0.obs;

  dynamic argumentData = Get.arguments;
  var foodDishes = RxList<FoodDish>();
  var categories = RxList<CategoryModel>();
  var selectedCategory = Rxn<CategoryModel>(); // order menu to filter fooddish
  var selectedCategories = RxList<CategoryModel>(); // for discount category

  var filteredFoodDishes = RxList<FoodDish>();

  var saleTable = Rxn<SaleTable>();
  var saleDetails = RxList<SaleDetail>();

  var search = ''.obs;
  var saleDetailExplanded = Rxn<int>();

  var authUser = Rxn<User>();

  // animal part
  var selectedFoodDish = Rxn<FoodDish>();
  var animalPartRemarkController = TextEditingController(text: '1');
  var animalPartQtyController = TextEditingController(text: '1');
  var animalParts = Rxn<Map<dynamic, List<Map<dynamic, dynamic>>>>();
  var animalPartSelectedIds = Rxn<Map<String, int?>>({});
  // var animalPartHeadId = Rxn<int>();
  // var animalPartTailId = Rxn<int>();
  // var animalPartWholeId = Rxn<int>();
  // var animalPartMixId = Rxn<int>();

  @override
  void onInit() {
    fetchFoodDish();
    super.onInit();
  }

  @override
  void onReady() {
    getSaleTableAndSaleDetailByTableId(
        Get.arguments['tableId'], Get.arguments['personCount']);

    final prefs = Get.find<SharedPreferences>();
    var usrString = prefs.getString('user');
    authUser.value = User.fromJson(jsonDecode(usrString ?? '{}'));
    getPrinters();
    super.onReady();
  }

  getAnimalParts(FoodDish foodDish) async {
    selectedFoodDish.value = foodDish;
    animalParts.value = null;
    try {
      var res = await orderRepository.getAnimalParts();
      animalParts.value = res;
    } catch (e) {
      rethrow;
    }
//food-dishes.animal-parts
  }

  getPrinters() async {
    try {
      printers.value = await printerRepository.getPrinters();
    } catch (e) {
      //
    }
  }

  searchFoodDish(String search) {
    if (search.isEmpty) {
      filteredFoodDishes.value = [];
    } else {
      filteredFoodDishes.value = foodDishes.where((e) {
        var names = [
          //e.englishName ?? '',
          //e.chineseName ?? '',
          //e.khmerName ?? '',
          //e.englishKeyword ?? '',
          e.chineseKeyword ?? '',
          e.khmerKeyword ?? ''
        ];
        return names
            .where((ei) =>
                ei.toLowerCase().contains(search) ||
                search.toLowerCase() == e.foodCode?.toLowerCase())
            .isNotEmpty;
      }).toList();
    }
  }

  filterFoodDishByCategory(int? categoryId) {
    if (categoryId == null) {
      filteredFoodDishes.value = foodDishes;
    }
    filteredFoodDishes.value = foodDishes.where((e) {
      return e.categoryId == categoryId;
    }).toList();
  }

  Future fetchFoodDish() async {
    try {
      final res = await orderRepository.getAllFoodDish();
      foodDishes.value = res.foodDish!;
      categories.value = res.categories!;
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  Future getSaleTableAndSaleDetailByTableId(
      int? diningTableId, int? personCount) async {
    try {
      final res = await orderRepository.getSaleTableAndSaleDetailByTableId(
          diningTableId, personCount);
      saleTable.value = res.data ?? SaleTable();
      saleDetails.value = res.data?.saleDetail ?? [];
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  Future increaseQty(
      {required int saleDetailId, required int diningTableId}) async {
    try {
      final res =
          await orderRepository.increaseQty(saleDetailId, diningTableId);
      saleTable.value = res.data!;
      saleDetails.value = res.data?.saleDetail ?? [];
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  Future decreaseQty(
      {required int saleDetailId,
      required int diningTableId,
      String? otpCode}) async {
    try {
      final res = await orderRepository.decreaseQty(
          saleDetailId, diningTableId, otpCode);
      saleTable.value = res.data!;
      saleDetails.value = res.data?.saleDetail ?? [];
      generatedOpt.value = '';
      Get.back();
    } catch (e) {
      if (e is DioException) {
        CommonWidget.toast(
            e.response?.data['message'] ?? 'Can Not Connect Server');
      }
    }
  }

  Future changeQty(
      {required int saleDetailId,
      required int diningTableId,
      String? otpCode,
      required double changeQty}) async {
    try {
      final res = await orderRepository.changeQty(
          saleDetailId: saleDetailId,
          diningTableId: diningTableId,
          otpCode: otpCode,
          changeQty: changeQty);
      saleTable.value = res.data!;
      saleDetails.value = res.data?.saleDetail ?? [];
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  Future<bool> addSaleDetail({
    String? saleTableId,
    double? qty,
    double? foodPrice,
    double? discountPercentage,
    FoodDish? foodDish,
    FoodDishDetail? foodDishDetail,
    int? headId,
    int? tailId,
    int? wholeId,
    int? mixId,
    String? remark,
  }) async {
    try {
      final res = await orderRepository.addSaleDetail(
        saleTableId: saleTableId,
        foodDishId: foodDish?.id,
        foodDishDetailId: foodDishDetail?.id,
        diningTableId: saleTable.value?.diningTableId,
        qty: qty ?? 1,
        foodPrice: foodPrice,
        discountPercentage: discountPercentage ?? 0,
        headId: headId,
        tailId: tailId,
        wholeId: wholeId,
        mixId: mixId,
        remark: remark,
      );
      saleTable.value = res.data!;
      saleDetails.value = res.data?.saleDetail ?? [];
      return true;
    } catch (e) {
      CommonWidget.toast(e.toString());
      return false;
    }
  }

  Future generateDeletionCodeForSaleDetail({required int saleDetailId}) async {
    try {
      final res = await orderRepository
          .generateDeletionCodeForSaleDetail(saleDetailId: saleDetailId)
          .then((value) {
        generatedOpt.value = value;
      });
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  printReceipt(int printerId, String? saleTableId) async {
    PrinterModel? printer = await printerRepository.getPrinterbyId(printerId);

    if (saleDetails.isEmpty) {
      CommonWidget.toast("No items to print");
      return;
    }

    var res = await printerRepository.getPrinterAndUpdateReceipPrintTime(
        saleTableId: saleTableId);
    saleTable.value = res.data!;

    if (printer != null) {
      PrinterServcie printerServcie = PrinterServcie(
          widget: ReportPrintReceipt(
              saleTable: saleTable.value!, saleDetails: saleDetails),
          printer: printer);

      printerServcie.print(Get.context!);
    }

    // Get show dialog
    // Get.dialog(ReportPrintReceipt(
    //     saleTable: saleTable.value.data!, saleDetails: billListData.value!));
  }

  printFoodToKichen() async {
    // Get.dialog(Dialog(
    //   child: ReportFoodForKichen(
    //       saleTable: saleTable.value!,
    //       saleDetails: saleDetails,
    //       user: authUser.value),
    // ));
    // return;

    List<SaleDetail> sDetails =
        saleDetails.where((sd) => (sd.qty ?? 0) > (sd.oldQty ?? 0)).toList();
    if (sDetails.isEmpty) {
      CommonWidget.toast("No items to print");
      return;
    }
    var groupSaleDetails =
        groupBy(sDetails, (sd) => sd.foodDishData?.category?.printerId);
    for (int? pid in groupSaleDetails.keys.toList()) {
      List<SaleDetail> details = groupSaleDetails[pid] ?? [];
      PrinterModel? p =
          details[0].foodDishData?.category?.printer ?? printers[0];
      if (p != null) {
        PrinterServcie printerServcie = PrinterServcie(
            widget: ReportFoodForKichen(
                saleTable: saleTable.value!,
                saleDetails: details,
                user: authUser.value),
            printer: p);

        printerServcie.print(Get.context!);
      }
    }

    try {
      var res =
          await orderRepository.printNewItems(saleTableId: saleTable.value?.id);
      saleTable.value = res.data ?? SaleTable();
      saleDetails.value = res.data?.saleDetail ?? [];
    } catch (e) {
      //
    }

    CommonWidget.toast('Items have been printed.');

    // Get show dialog
    // Get.dialog(ReportPrintReceipt(
    //     saleTable: saleTable.value.data!, saleDetails: billListData.value!));
  }

  printFood(PrinterModel printer, report) async {
    // Get show dialog
    // Get.dialog(
    //   report,
    // );
    // return;
    try {
      PrinterServcie printerServcie =
          PrinterServcie(widget: report, printer: printer);

      printerServcie.print(Get.context!);
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }

  submitDiscount(
      {required int typeToDiscount,
      required double discountPercentage,
      String? saleTableId,
      int? saleDetailId,
      List? categoryIds}) async {
    try {
      final res = await orderRepository.submitDiscount(
        typeToDiscount: typeToDiscount,
        saleTableId: saleTableId,
        saleDetailId: saleDetailId,
        discountPercentage: discountPercentage,
        categoryIds: categoryIds,
      );
      saleTable.value = res.data;
      saleDetails.value = res.data?.saleDetail ?? [];
    } catch (e) {
      CommonWidget.toast(e.toString());
    }
  }
}
