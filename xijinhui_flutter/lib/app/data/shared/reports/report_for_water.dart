import 'package:chuanmapo_flutter/app/data/models/response/login_response.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class ReportForWater extends StatelessWidget {
  final SaleTable saleTable;
  final User? user;
  final List<SaleDetail> saleDetails;
  const ReportForWater(
      {super.key,
      required this.saleTable,
      required this.saleDetails,
      this.user});

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
              _buildRow(
                'Cashier : ',
                user?.username.toString() ?? '',
              ),
              _buildRow(
                'EventDate : ',
                formatDateTime(DateTime.now()),
              ),
              _buildRow(
                  'Table : ', saleTable.diningTable?.diningTableCode ?? ''),
              _buildRow('Person Count : ', saleTable.personCount.toString()),
              const Divider(
                height: 20,
                thickness: 3,
                //indent: 20,
                endIndent: 0,
                color: Colors.black,
              ),
              Container(
                padding: const EdgeInsets.symmetric(vertical: 10),
                child: const Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Expanded(flex: 7, child: Text('Description')),
                    Expanded(flex: 2, child: Text('Qty')),
                  ],
                ),
              ),
              for (var saleDetail in saleDetails) ...[
                Container(
                  padding: const EdgeInsets.symmetric(vertical: 10),
                  decoration: const BoxDecoration(
                      border: Border(top: BorderSide(color: Colors.black))),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Expanded(
                        flex: 7,
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(saleDetail.getFullDescription()),
                          ],
                        ),
                      ),
                      Expanded(
                          flex: 2,
                          child: Text(
                              ((saleDetail.qty ?? 0) - (saleDetail.oldQty ?? 0))
                                  .toString())),
                    ],
                  ),
                ),
              ],
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

  String formatDateTime(DateTime dateTime) {
    return DateFormat('yyyy-MM-dd h:mm a').format(dateTime);
  }
}
