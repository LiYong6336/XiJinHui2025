import 'package:chuanmapo_flutter/app/data/api/repository/printer_repository.dart';
import 'package:chuanmapo_flutter/app/data/api/repository/sale_payment_repository.dart';
import 'package:chuanmapo_flutter/app/data/models/response/payment_method_response.dart';
import 'package:chuanmapo_flutter/app/data/models/response/sale_table_response.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';
import 'package:chuanmapo_flutter/app/data/shared/reports/report_print_invoice.dart';
import 'package:chuanmapo_flutter/app/data/shared/services/printer_service.dart';
import 'package:chuanmapo_flutter/app/data/shared/utils/common_widget.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class SalePaymentController extends GetxController {
  var salePaymentRepository = SalePaymentRepository();
  var printerRepository = PrinterRepository();

  SaleTable? saleTable;
  var selectedPaymentMentods = <PaymentMethod>[].obs;
  var textPaymentDollar = ''.obs;
  var textPaymentRiels = ''.obs;

  var textReceiveDollarsMap = <int, TextEditingController>{}.obs;
  var textReceiveRielsMap = <int, TextEditingController>{}.obs;

  var textChangeDollar = '0'.obs;
  var textChangeRiels = '0'.obs;

  var totalReceived = 0.0.obs;

  @override
  void onReady() {
    saleTable = Get.arguments['sale_table'];
    textPaymentDollar.value = saleTable?.grandTotal?.toString() ?? '0';
    textPaymentRiels.value =
        ((saleTable?.grandTotal ?? 0) * (saleTable?.exchangeRate ?? 0))
            .toString();
    super.onReady();
  }

  addPaymentMethod(PaymentMethod paymentMethod) {
    selectedPaymentMentods.add(paymentMethod);
    textReceiveDollarsMap.putIfAbsent(
        paymentMethod.id!, () => TextEditingController());
    textReceiveRielsMap.putIfAbsent(
        paymentMethod.id!, () => TextEditingController());
  }

  calculateChange() {
    double receiveDollar = 0;
    double receiveRiels = 0;
    // get all receive dollar
    textReceiveDollarsMap.forEach((key, value) {
      receiveDollar += double.tryParse(value.text) ?? 0;
    });
    // get all receive riels
    textReceiveRielsMap.forEach((key, value) {
      receiveRiels += double.tryParse(value.text) ?? 0;
    });
    totalReceived.value =
        receiveDollar + (receiveRiels / (saleTable?.exchangeRate ?? 0));
    // calculate change
    double changeAmount = (totalReceived.value - saleTable!.grandTotal!);
    double decimalNum = changeAmount - changeAmount.toInt();
    textChangeDollar.value = (changeAmount - decimalNum).toString();
    int roundRiel =
        ((decimalNum * saleTable!.exchangeRate! / 100).toInt() * 100);
    textChangeRiels.value = (roundRiel).toString();
  }

  Future<SaleTableResponse> submitPayment(int printerId) async {
    double changeDollar = double.tryParse(textChangeDollar.value) ?? 0;
    double changeRiels = double.tryParse(textChangeRiels.value) ?? 0;
    double totalChanges =
        changeDollar + (changeRiels / (saleTable?.exchangeRate ?? 0));
    if (totalChanges >= 0) {
      // submit
      // get all textReceiveDollarsMap and textReceiveRielsMap
      // get all selectedPaymentMentods
      List<Map> payments = selectedPaymentMentods.map((e) {
        return {
          'payment_method_id': e.id,
          'amount_dollar': textReceiveDollarsMap[e.id]?.text,
          'amount_riel':
              double.tryParse(textReceiveRielsMap[e.id]?.text ?? '0') ?? 0,
        };
      }).toList();
      PrinterModel? printer = await printerRepository.getPrinterbyId(printerId);

      return salePaymentRepository
          .submitPayment(saleTableId: saleTable!.id!, payments: payments)
          .then((value) {
        if (printer != null) {
          // Get.dialog(
          //   ReportPrintReceipt(
          //       saleTable: value.data!, saleDetails: value.data!.saleDetail!),
          // );
          PrinterServcie printerServcie = PrinterServcie(
              widget: ReportPrintReceipt(
                  saleTable: value.data!, saleDetails: value.data!.saleDetail!),
              printer: printer);

          printerServcie.print(Get.context!);
        }
        Get.offAllNamed('/home');
        return value;
      }).catchError((e) {
        CommonWidget.toast(e.toString());
      });
    }
    // show error
    CommonWidget.toast('Please check your change amount');
    throw 'Please check your change amount';
  }
}
