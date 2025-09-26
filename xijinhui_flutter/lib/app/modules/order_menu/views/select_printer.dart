import 'package:chuanmapo_flutter/app/data/shared/services/printer_service.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class SelectPrinter extends GetView<OrderMenuController> {
  final Widget? report;
  //final Function(PrinterModel printer)? onPressed;

  const SelectPrinter({
    super.key,
    this.report,
    //this.onPressed,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 440,
      height: 400,
      padding: const EdgeInsets.all(10),
      child: GridView.count(
        crossAxisCount: 4,
        mainAxisSpacing: 10,
        crossAxisSpacing: 10,
        children: [
          for (PrinterModel p in controller.printers)
            ElevatedButton(
              //onPressed: () => onPressed!(p),
              onPressed: () {
                controller.printFood(p, report);
                Get.back();
              },
              child: Text(p.id.toString()),
            ),
        ],
      ),
    );
  }
}
