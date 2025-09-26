import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class ReportPrintReceipt extends StatelessWidget {
  final SaleTable saleTable;
  final List<SaleDetail> saleDetails;
  const ReportPrintReceipt(
      {super.key, required this.saleTable, required this.saleDetails});

  @override
  Widget build(BuildContext context) {
    return Container(
        padding: const EdgeInsets.all(20),
        color: Colors.white,
        child: DefaultTextStyle(
          style: const TextStyle(fontSize: 18, color: Colors.black),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Image.asset('assets/images/InvoiceHeader.png',
                  width: 300, height: 100),
              const SizedBox(height: 10),
              _buildRow(
                'Cashier : ',
                saleTable.user!.username.toString(),
              ),
              _buildRow(
                'EventDate : ',
                formatDateTime(saleTable.saleDate.toString()),
              ),
              _buildRow(
                  'Table : ', saleTable.diningTable?.diningTableCode ?? ''),
              const Divider(
                height: 20,
                thickness: 3,
                //indent: 20,
                endIndent: 0,
                color: Colors.black,
              ),
              const Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Expanded(flex: 7, child: Text('Description')),
                  Expanded(flex: 2, child: Text('Qty')),
                  Expanded(flex: 4, child: Text('Unit Price')),
                  Expanded(flex: 3, child: Text('Amount')),
                ],
              ),
              for (var saleDetail in saleDetails) ...[
                Container(
                  padding: const EdgeInsets.symmetric(vertical: 10),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Expanded(
                        flex: 7,
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(saleDetail.foodDishData?.englishName ?? ''),
                            Text(saleDetail.foodDishData?.chineseName ?? ''),
                            Text(saleDetail.foodDishData?.khmerName ?? ''),
                            (saleDetail.discountPercentage ?? 0) == 0
                                ? Container()
                                : Text(
                                    '( ${saleDetail.discountPercentage.toString()} % )' ??
                                        ''),
                          ],
                        ),
                      ),
                      Expanded(flex: 2, child: Text(saleDetail.qty.toString())),
                      Expanded(
                          flex: 4,
                          child: Text(saleDetail.foodPrice.toString())),
                      Expanded(
                          flex: 3,
                          child: Text(saleDetail.totalAmount.toString())),
                    ],
                  ),
                ),
              ],
              const Divider(
                height: 20,
                thickness: 3,
                //indent: 20,
                endIndent: 0,
                color: Colors.black,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text('Total', style: TextStyle(fontSize: 28)),
                  Text(saleTable.totalAmount.toString(),
                      style: const TextStyle(fontSize: 28)),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text(
                    'Discount (${saleTable.discountPercentage})%',
                    style: const TextStyle(fontSize: 28),
                  ),
                  Text(
                    saleTable.discountAmount.toString(),
                    style: const TextStyle(fontSize: 28),
                  ),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text(
                    'Grand Total',
                    style: TextStyle(fontSize: 28, fontWeight: FontWeight.bold),
                  ),
                  Text(
                    saleTable.grandTotal.toString(),
                    style: const TextStyle(
                        fontSize: 28, fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ],
          ),
        ));
  }

  Widget _buildRow(String label, String value) {
    return Row(children: [
      Expanded(
          flex: 1, child: Text(label, style: const TextStyle(fontSize: 20))),
      Expanded(
          flex: 2, child: Text(value, style: const TextStyle(fontSize: 20))),
    ]);
  }

  // format datetime

  String formatDateTime(String dateTimeString) {
    DateTime dateTime = DateTime.tryParse(dateTimeString) ?? DateTime.now();

    return DateFormat('yyyy-MM-dd').format(dateTime);
  }
}
