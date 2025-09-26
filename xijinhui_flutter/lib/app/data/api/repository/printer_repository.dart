import 'package:chuanmapo_flutter/app/data/api/api_service.dart';
import 'package:chuanmapo_flutter/app/data/models/response/sale_table_response.dart';
import 'package:chuanmapo_flutter/app/data/shared/services/printer_service.dart';

class PrinterRepository extends ApiService {
  Future<List<PrinterModel>> getPrinters() async {
    return await get('printers').then((value) {
      List data = value.data['data'] ?? [];
      return data.map((e) => PrinterModel.fromJson(e)).toList();
    }).catchError((err) {
      throw err;
    });
  }

  Future<PrinterModel?> getPrinterbyId(int printerId) async {
    return await get('printers/$printerId').then((value) {
      return PrinterModel.fromJson(value.data['data']);
    }).catchError((err) {
      throw err;
    });
  }

  Future<SaleTableResponse> getPrinterAndUpdateReceipPrintTime(
      {required String? saleTableId}) async {
    return await post('getPrinterAndUpdateReceiptPrintTime',
        data: {'sale_table_id': saleTableId}).then((value) {
      return SaleTableResponse.fromJson(value.data);
    }).catchError((err) {
      throw err;
    });
  }
}
