import 'package:chuanmapo_flutter/app/data/shared/reports/report_for_water.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/discount_category.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/discount_percentage.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/select_printer.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class AddCustomerDetailHeader extends StatelessWidget {
  OrderMenuController controller;

  AddCustomerDetailHeader({super.key, required this.controller});

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        //IconButton(
        //  icon: const Icon(Icons.category),
        //  onPressed: () {
        //    Get.dialog(
        //        barrierDismissible: true,
        //        Dialog(
        //          backgroundColor: Colors.white,
        //          child: DiscountCategory(
        //            typeToDiscount: 0,
        //            saleId: controller.saleTable.value?.id,
        //          ),
        //        ));
        //  },
        //),
        //IconButton(
        //  icon: const Icon(Icons.percent),
        //  onPressed: () {
        //    Get.dialog(
        //        barrierDismissible: true,
        //        Dialog(
        //          backgroundColor: Colors.white,
        //          child: DiscountPercentage(
        //            typeToDiscount: 1,
        //            saleId: controller.saleTable.value?.id,
        //          ),
        //        ));
        //  },
        //),
        // IconButton(
        //   icon: const Icon(Icons.category),
        //   onPressed: () {
        //     // controller.checkExistSaleTable();
        //   },
        // ),
        IconButton(
          icon: const Icon(Icons.liquor),
          onPressed: () {
            var sDetails = controller.saleDetails
                .where((e) => e.foodDishData?.category?.isDrink == true)
                .toList();
            if (sDetails.isEmpty) {
              CommonWidget.toast("No items to print");
              return;
            }
            var report = ReportForWater(
              user: controller.authUser.value,
              saleTable: controller.saleTable.value!,
              saleDetails: sDetails,
            );
            Get.dialog(
              Dialog(
                child: SelectPrinter(
                  report: report,
                ),
              ),
            );
          },
        ),
        IconButton(
          icon: const Icon(Icons.soup_kitchen),
          onPressed: () {
            var sDetails = controller.saleDetails
                .where((e) => e.foodDishData?.category?.isDrink == false)
                .toList();
            if (sDetails.isEmpty) {
              CommonWidget.toast("No items to print");
              return;
            }
            var report = ReportForWater(
              user: controller.authUser.value,
              saleTable: controller.saleTable.value!,
              saleDetails: sDetails,
            );
            Get.dialog(
              Dialog(
                child: SelectPrinter(
                  report: report,
                ),
              ),
            );
            //controller.printFood();
          },
        ),
        IconButton(
          icon: const Icon(Icons.stairs),
          onPressed: () {
            if (controller.saleDetails.isEmpty) {
              CommonWidget.toast("No items to print");
              return;
            }
            var report = ReportForWater(
              saleTable: controller.saleTable.value!,
              saleDetails: controller.saleDetails,
            );
            Get.dialog(
              Dialog(
                child: SelectPrinter(
                  report: report,
                ),
              ),
            );
          },
        ),

        // ElevatedButton(
        //   onPressed: () {},
        //   style: ButtonStyle(
        //     elevation: MaterialStateProperty.all(0),
        //     backgroundColor: MaterialStateProperty.all(Colors.grey.shade100),
        //     shape: MaterialStateProperty.all<RoundedRectangleBorder>(
        //       RoundedRectangleBorder(
        //         borderRadius: BorderRadius.circular(6.0),
        //       ),
        //     ),
        //   ),
        //   child: Row(
        //     children: [
        //       const Icon(Icons.add, color: Colors.black),
        //       Text(
        //         'Add Customer',
        //         style: GoogleFonts.poppins(color: Colors.black),
        //       ),
        //     ],
        //   ),
        // ),
        const Spacer(),
        // GestureDetector(
        //   onTap: () {},
        //   child: Container(
        //     width: 50,
        //     height: 50,
        //     decoration: BoxDecoration(
        //         color: Colors.grey.shade100,
        //         borderRadius: BorderRadius.circular(12)),
        //     child: const Padding(
        //       padding: EdgeInsets.all(8.0),
        //       child: Icon(
        //         Icons.add,
        //         color: Colors.black,
        //       ),
        //     ),
        //   ),
        // ),
        // const SizedBox(width: 10),
        // GestureDetector(
        //   onTap: () {},
        //   child: Container(
        //     width: 50,
        //     height: 50,
        //     decoration: BoxDecoration(
        //         color: Colors.grey.shade100,
        //         borderRadius: BorderRadius.circular(12)),
        //     child: const Padding(
        //       padding: EdgeInsets.all(8.0),
        //       child: Icon(
        //         Icons.airplane_ticket_sharp,
        //         color: Colors.black,
        //       ),
        //     ),
        //   ),
        // ),
        //const SizedBox(width: 10),
        GestureDetector(
          onTap: () {
            controller.getSaleTableAndSaleDetailByTableId(
                controller.saleTable.value?.diningTableId,
                controller.saleTable.value?.personCount);
            controller.fetchFoodDish();
          },
          child: Container(
            width: 50,
            height: 50,
            decoration: BoxDecoration(
                color: Colors.grey.shade100,
                borderRadius: BorderRadius.circular(12)),
            child: const Padding(
              padding: EdgeInsets.all(8.0),
              child: Icon(
                Icons.replay_outlined,
                color: Colors.black,
              ),
            ),
          ),
        ),
        const SizedBox(width: 10),
      ],
    );
  }
}
