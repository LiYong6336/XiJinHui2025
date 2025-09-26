import 'package:cached_network_image/cached_network_image.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/shared/reports/report_for_water.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/discount_category.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/discount_percentage.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/qty_changer.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/select_printer.dart';
import 'package:chuanmapo_flutter/app/modules/payment_method/controllers/payment_method_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class BillListView extends GetView<OrderMenuController> {
  const BillListView({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Bill'),
          actions: [
            IconButton(
              icon: const Icon(Icons.category),
              onPressed: () {
                Get.dialog(
                    barrierDismissible: true,
                    Dialog(
                      backgroundColor: Colors.white,
                      child: DiscountCategory(
                        typeToDiscount: 0,
                        saleId: controller.saleTable.value?.id,
                      ),
                    ));
              },
            ),
            IconButton(
              icon: const Icon(Icons.percent),
              onPressed: () {
                Get.dialog(
                    barrierDismissible: true,
                    Dialog(
                      backgroundColor: Colors.white,
                      child: DiscountPercentage(
                        typeToDiscount: 1,
                        saleId: controller.saleTable.value?.id,
                      ),
                    ));
              },
            ),
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
          ],
        ),
        body: Column(
          children: [
            Expanded(
              child: Obx(
                () => Container(
                  padding: const EdgeInsets.all(10),
                  child: ListView.separated(
                      separatorBuilder: (BuildContext context, int index) =>
                          const Divider(),
                      itemCount: controller.saleDetails.length,
                      itemBuilder: (BuildContext context, int index) {
                        SaleDetail saleDetail = controller.saleDetails[index];
                        FoodDish? foodDish = saleDetail.foodDishData;
                        FoodDishDetail? foodDishDetail =
                            saleDetail.foodDishDetailData;

                        return ListTile(
                          selectedColor: Colors.blue,
                          contentPadding: EdgeInsets.zero,
                          onTap: () {
                            Get.dialog(
                                barrierDismissible: true,
                                Dialog(
                                  backgroundColor: Colors.white,
                                  child: DiscountPercentage(
                                    typeToDiscount: 2,
                                    saleDetailId: saleDetail.id,
                                  ),
                                ));
                          },
                          onLongPress: () {
                            Get.snackbar('longpress', 'Will Delete');
                          },
                          title: Container(
                            child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                if (foodDish?.englishName != null)
                                  Text(
                                      "${foodDish?.englishName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.englishName})' : ''}"),
                                if (foodDish?.chineseName != null)
                                  Text(
                                      "${foodDish?.chineseName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.chineseName})' : ''}"),
                                if (foodDish?.khmerName != null)
                                  Text(
                                      "${foodDish?.khmerName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.khmerName})' : ''}")
                              ],
                            ),
                          ),
                          subtitle: Text(
                              "${saleDetail.foodPrice} x ${saleDetail.qty} "
                              "(${saleDetail.discountPercentage}%) = "
                              "${saleDetail.totalAmountAfterDiscount}"),
                          leading: foodDish?.foodPhoto != null
                              ? CachedNetworkImage(
                                  imageUrl: foodDish?.foodPhotoUrl ?? '',
                                  width: 50,
                                  height: 50,
                                  fit: BoxFit.cover,
                                  errorWidget: (context, url, error) =>
                                      Image.asset(
                                    //'assets/icons/icon.png',
                                    'assets/images/food-dish-placeholder.jpg',
                                    width: 120,
                                    height: 120,
                                    fit: BoxFit.cover,
                                  ),
                                )
                              : Image.asset(
                                  'assets/images/food-dish-placeholder.jpg',
                                  width: 50,
                                  height: 50,
                                  fit: BoxFit.cover,
                                ),
                          trailing: QtyChanger(
                            saleDetail: saleDetail,
                          ),
                        );
                      }),
                ),
              ),
            ),
            Container(
              padding: const EdgeInsets.only(
                  top: 10, left: 10, right: 10, bottom: 5),
              height: 150,
              //color: Colors.red,
              child: DefaultTextStyle(
                style: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                  color: Colors.black,
                ),
                child: Column(
                  children: [
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text('Subtotal'),
                        Text(
                          '${controller.saleTable.value?.totalAmount ?? 0.0}',
                        )
                      ],
                    ),
                    //const SizedBox(height: 10),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Text(
                          'Discount (${controller.saleTable.value?.discountPercentage ?? 0.0}%)',
                        ),
                        Text(
                          '${controller.saleTable.value?.discountAmount}',
                        )
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text(
                          'Room Service',
                        ),
                        Text(
                          '${controller.saleTable.value?.roomServiceAmount ?? 0.0}',
                        )
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text(
                          'Tax',
                        ),
                        Text(
                          '${controller.saleTable.value?.taxAmount ?? 0.0}',
                        )
                      ],
                    ),
                    const SizedBox(height: 10),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        const Text(
                          'Payable Amount',
                        ),
                        Text(
                          '${controller.saleTable.value?.grandTotal ?? 0.0}',
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
            Container(
              padding: const EdgeInsets.only(left: 10, right: 10, bottom: 5),
              child: Row(
                children: [
                  // Expanded(
                  //   child: GestureDetector(
                  //     onTap: () {
                  //       Get.dialog(
                  //         barrierDismissible: true,
                  //         Dialog(
                  //           backgroundColor: Colors.white,
                  //           child: DiscountPercentage(
                  //             typeToDiscount: 1,
                  //             saleId: controller.saleTable.value?.id,
                  //           ),
                  //         ),
                  //       );
                  //     },
                  //     child: Container(
                  //       height: 40,
                  //       decoration: BoxDecoration(
                  //           color: ColorClass.orangeColor,
                  //           borderRadius: BorderRadius.circular(8)),
                  //       child: Row(
                  //         mainAxisAlignment: MainAxisAlignment.center,
                  //         children: [
                  //           const Icon(
                  //             Icons.discount,
                  //             color: Colors.white,
                  //           ),
                  //           const SizedBox(width: 5),
                  //           Text(
                  //             'Discount',
                  //             style: GoogleFonts.poppins(
                  //                 color: Colors.white,
                  //                 fontWeight: FontWeight.w600,
                  //                 fontSize: 14),
                  //           )
                  //         ],
                  //       ),
                  //     ),
                  //   ),
                  // ),
                  // const SizedBox(width: 5),
                  Expanded(
                    child: Container(
                      height: 40,
                      decoration: BoxDecoration(
                          color: Colors.blue,
                          borderRadius: BorderRadius.circular(8)),
                      child: GestureDetector(
                        onTap: () {
                          controller.printFoodToKichen();
                        },
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            const Icon(
                              Icons.print,
                              color: Colors.white,
                            ),
                            const SizedBox(width: 5),
                            Text(
                              'Order',
                              style: GoogleFonts.poppins(
                                  color: Colors.white,
                                  fontWeight: FontWeight.w600,
                                  fontSize: 14),
                            )
                          ],
                        ),
                      ),
                    ),
                  ),
                ],
              ),
            ),
            // Container(
            //   padding: const EdgeInsets.only(left: 10, right: 10, bottom: 10),
            //   child: Row(
            //     children: [
            //       Expanded(
            //         child: Container(
            //           height: 40,
            //           decoration: BoxDecoration(
            //               color: Colors.blue,
            //               borderRadius: BorderRadius.circular(8)),
            //           child: GestureDetector(
            //             onTap: () {
            //               controller.printReceipt(
            //                   1, "${controller.saleTable.value?.id ?? 0}");
            //             },
            //             child: Row(
            //               mainAxisAlignment: MainAxisAlignment.center,
            //               children: [
            //                 const Icon(
            //                   Icons.print,
            //                   color: Colors.white,
            //                 ),
            //                 const SizedBox(width: 5),
            //                 Text(
            //                   'Print',
            //                   style: GoogleFonts.poppins(
            //                       color: Colors.white,
            //                       fontWeight: FontWeight.w600,
            //                       fontSize: 14),
            //                 )
            //               ],
            //             ),
            //           ),
            //         ),
            //       ),
            //       //IconButton(onPressed: () {}, icon: Icon(Icons.money)),
            //       const SizedBox(width: 5),
            //       Expanded(
            //         child: Container(
            //           height: 40,
            //           decoration: BoxDecoration(
            //               color: ColorClass.greenColor,
            //               borderRadius: BorderRadius.circular(8)),
            //           child: GestureDetector(
            //             onTap: () {
            //               Get.put(PaymentMethodController());
            //               Get.toNamed('sale-payment', arguments: {
            //                 'sale_table': controller.saleTable.value,
            //               });
            //             },
            //             child: Row(
            //               mainAxisAlignment: MainAxisAlignment.center,
            //               children: [
            //                 Transform.rotate(
            //                   angle: 1.5,
            //                   child: const Icon(
            //                     Icons.arrow_circle_up_outlined,
            //                     color: Colors.white,
            //                   ),
            //                 ),
            //                 const SizedBox(width: 5),
            //                 Text(
            //                   'Payment',
            //                   style: GoogleFonts.poppins(
            //                       color: Colors.white,
            //                       fontWeight: FontWeight.w600,
            //                       fontSize: 14),
            //                 )
            //               ],
            //             ),
            //           ),
            //         ),
            //       ),
            //     ],
            //   ),
            // ),
          ],
        ));
  }
}
