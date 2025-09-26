import 'package:chuanmapo_flutter/app/data/models/dining_table.dart';
import 'package:chuanmapo_flutter/app/data/models/response/login_response.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';

class SaleTable {
  String? id;
  int? diningTableId;
  int? salePaymentId;
  int? userId;
  String? saleOrderNumber;
  String? showingInvoiceNumber;
  String? invoiceNumber;
  DateTime? saleDate;
  double? totalAmount;
  double? grandTotalSaleDetail;
  double? grandTotal;
  String? remark;
  double? discountPercentage;
  double? discountAmount;
  double? paymentDollar;
  double? paymentRiel;
  double? returnDollars;
  double? returnRiels;
  double? exchangeRate;
  DateTime? finishedDiningDate;
  int? takeTime;
  int? personCount;
  int? preReceiptPrintTime;
  int? receiptPrintTime;
  double? taxAmount;
  double? roomServiceAmount;
  int? makingStatus;
  int? statusCode;
  int? taxDeclaration;
  int? clearingUserId;
  DateTime? clearingDatetime;
  List<SaleDetail>? saleDetail;
  User? user;
  DiningTable? diningTable;

  SaleTable(
      {this.id,
      this.diningTableId,
      this.salePaymentId,
      this.userId,
      this.saleOrderNumber,
      this.showingInvoiceNumber,
      this.invoiceNumber,
      this.saleDate,
      this.totalAmount,
      this.grandTotalSaleDetail,
      this.grandTotal,
      this.remark,
      this.discountPercentage,
      this.discountAmount,
      this.paymentDollar,
      this.paymentRiel,
      this.returnDollars,
      this.returnRiels,
      this.exchangeRate,
      this.finishedDiningDate,
      this.takeTime,
      this.personCount,
      this.preReceiptPrintTime,
      this.receiptPrintTime,
      this.taxAmount,
      this.roomServiceAmount,
      this.makingStatus,
      this.statusCode,
      this.taxDeclaration,
      this.clearingUserId,
      this.clearingDatetime,
      this.saleDetail,
      this.user,
      this.diningTable});

  SaleTable.fromJson(Map<String, dynamic> json) {
    id = '${json['id']}';
    diningTableId = int.tryParse('${json['dining_table_id']}');
    salePaymentId = int.tryParse('${json['sale_payment_id']}');
    userId = int.tryParse('${json['user_id']}');
    saleOrderNumber = json['sale_order_number'];
    showingInvoiceNumber = json['showing_invoice_number'];
    invoiceNumber = json['invoice_number'];
    saleDate = DateTime.tryParse('${json['sale_date']}');
    totalAmount = double.tryParse('${json['total_amount']}');
    grandTotalSaleDetail =
        double.tryParse('${json['grand_total_sale_detail']}');
    grandTotal = double.tryParse('${json['grand_total']}');
    remark = json['remark'];
    discountPercentage = double.tryParse('${json['discount_percentage']}');
    discountAmount = double.tryParse('${json['discount_amount']}');
    paymentDollar = double.tryParse('${json['payment_dollar']}');
    paymentRiel = double.tryParse('${json['payment_riel']}');
    returnDollars = double.tryParse('${json['return_dollars']}');
    returnRiels = double.tryParse('${json['return_riels']}');
    exchangeRate = double.tryParse('${json['exchange_rate']}');
    finishedDiningDate = DateTime.tryParse('${json['finished_dining_date']}');
    takeTime = int.tryParse('${json['take_time']}');
    personCount = int.tryParse('${json['person_count']}');
    preReceiptPrintTime = int.tryParse('${json['pre_receipt_print_time']}');
    receiptPrintTime = int.tryParse('${json['receipt_print_time']}');
    taxAmount = double.tryParse('${json['tax_amount']}');
    roomServiceAmount = double.tryParse('${json['room_service_amount']}');
    makingStatus = int.tryParse('${json['making_status']}');
    statusCode = int.tryParse('${json['status_code']}');
    taxDeclaration = int.tryParse('${json['tax_declaration']}');
    clearingUserId = int.tryParse('${json['clearing_user_id']}');
    clearingDatetime = DateTime.tryParse('${json['']}');

    if (json['sale_detail'] != null) {
      saleDetail = <SaleDetail>[];
      json['sale_detail'].forEach((v) {
        saleDetail!.add(SaleDetail.fromJson(v));
      });
    }
    user = json['user'] != null ? User.fromJson(json['user']) : null;
    diningTable = json['dining_table'] != null
        ? DiningTable.fromJson(json['dining_table'])
        : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['dining_table_id'] = diningTableId;
    data['sale_payment_id'] = salePaymentId;
    data['user_id'] = userId;
    data['sale_order_number'] = saleOrderNumber;
    data['showing_invoice_number'] = showingInvoiceNumber;
    data['invoice_number'] = invoiceNumber;
    data['sale_date'] = saleDate;
    data['total_amount'] = totalAmount;
    data['grand_total_sale_detail'] = grandTotalSaleDetail;
    data['grand_total'] = grandTotal;
    data['remark'] = remark;
    data['discount_percentage'] = discountPercentage;
    data['discount_amount'] = discountAmount;
    data['payment_dollar'] = paymentDollar;
    data['payment_riel'] = paymentRiel;
    data['return_dollars'] = returnDollars;
    data['return_riels'] = returnRiels;
    data['exchange_rate'] = exchangeRate;
    data['finished_dining_date'] = finishedDiningDate;
    data['take_time'] = takeTime;
    data['person_count'] = personCount;
    data['pre_receipt_print_time'] = preReceiptPrintTime;
    data['receipt_print_time'] = receiptPrintTime;
    data['tax_amount'] = taxAmount;
    data['room_service_amount'] = roomServiceAmount;
    data['making_status'] = makingStatus;
    data['status_code'] = statusCode;
    data['tax_declaration'] = taxDeclaration;
    data['clearing_user_id'] = clearingUserId;
    data['clearing_datetime'] = clearingDatetime;
    if (saleDetail != null) {
      data['sale_detail'] = saleDetail!.map((v) => v.toJson()).toList();
    }
    if (user != null) {
      data['user'] = user!.toJson();
    }
    if (diningTable != null) {
      data['dining_table'] = diningTable!.toJson();
    }
    return data;
  }
}
