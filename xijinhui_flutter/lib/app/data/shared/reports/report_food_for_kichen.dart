import 'package:flutter/rendering.dart';
import 'package:chuanmapo_flutter/app/data/models/response/login_response.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_table.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class ReportFoodForKichen extends StatelessWidget {
  final SaleTable saleTable;
  final User? user;
  final List<SaleDetail> saleDetails;
  const ReportFoodForKichen(
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
          style: const TextStyle(fontSize: 32, color: Colors.black),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              Row(
                children: [
                  Expanded(
                    flex: 2,
                    child: Column(
                      children: [
                        Text(
                          saleDetails[0].foodDishData?.category?.englishName ??
                              '',
                          style: TextStyle(fontSize: 32),
                        ),
                        Text(formatDateTime(DateTime.now()),
                            style: TextStyle(fontSize: 24)),
                      ],
                    ),
                  ),
                  Expanded(
                    flex: 1,
                    child: Text(
                      saleTable.diningTable?.diningTableCode ?? '',
                      style: TextStyle(fontSize: 32),
                      textAlign: TextAlign.right,
                    ),
                  ),
                ],
              ),
              SizedBox(height: 10),
              _buildRow(
                'Cashier : ',
                user!.username.toString(),
              ),
              // _buildRow(
              //   'EventDate : ',
              //   ,
              // ),
              // _buildRow(
              //   'Table : ',
              // ),
              // const Divider(
              //   height: 20,
              //   thickness: 3,
              //   //indent: 20,
              //   endIndent: 0,
              //   color: Colors.black,
              // ),
              for (var saleDetail in saleDetails) ...[
                Container(
                  padding: const EdgeInsets.symmetric(vertical: 10),
                  decoration: const BoxDecoration(
                      border: Border(top: BorderSide(color: Colors.black))),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      Row(children: [
                        Expanded(
                          child: Text(
                            saleDetail.getFullDescription(),
                            style: TextStyle(fontSize: 32),
                          ),
                        )
                      ]),
                      Row(children: [
                        Text('Qty: ', style: TextStyle(fontSize: 32)),
                        Expanded(
                          child: Container(
                            padding: EdgeInsets.only(right: 5),
                            decoration: BoxDecoration(
                                border: Border.all(color: Colors.black)),
                            child: Text(
                              ((saleDetail.qty ?? 0) - (saleDetail.oldQty ?? 0))
                                  .toString(),
                              style: TextStyle(fontSize: 32),
                              textAlign: TextAlign.right,
                            ),
                          ),
                        )
                      ]),
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
          flex: 1, child: Text(label, style: const TextStyle(fontSize: 32))),
      Expanded(
          flex: 2, child: Text(value, style: const TextStyle(fontSize: 32))),
    ]);
  }

  // format datetime

  String formatDateTime(DateTime dateTime) {
    return DateFormat('yyyy-MM-dd h:mm a').format(dateTime);
  }
}
