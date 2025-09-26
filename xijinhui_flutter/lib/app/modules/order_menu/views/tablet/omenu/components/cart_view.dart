import 'package:cached_network_image/cached_network_image.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish.dart';
import 'package:chuanmapo_flutter/app/data/models/food_dish_detail.dart';
import 'package:chuanmapo_flutter/app/data/models/sale_detail.dart';
import 'package:chuanmapo_flutter/app/data/shared/constants/colors.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/discount_percentage.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/qty_changer.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/omenu/components/add_customer_detail_header.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/omenu/components/custom_expansion_tile.dart';
import 'package:chuanmapo_flutter/app/modules/payment_method/controllers/payment_method_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class CardView extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  CardView({super.key});

  @override
  Widget build(BuildContext context) {
    return Obx(
      () => Container(
        decoration: const BoxDecoration(
          color: Colors.white,
          boxShadow: [
            BoxShadow(color: Colors.black12, blurRadius: 4),
          ],
        ),
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.all(4.0),
              child: AddCustomerDetailHeader(controller: controller),
            ),
            const SizedBox(height: 8),
            const Divider(),
            const SizedBox(height: 8),
            Expanded(
              child: SingleChildScrollView(
                child: Column(
                  children: [
                    for (SaleDetail saleDetail in controller.saleDetails)
                      _saleDetailItem(saleDetail),
                  ],
                ),
              ),
            ),
            // const Padding(
            //   padding: EdgeInsets.all(8.0),
            //   child: AddTile(),
            // ),
            Container(
              padding: const EdgeInsets.all(12),
              width: Get.width,
              color: Colors.grey.shade100,
              child: Column(
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        'Subtotal',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.w500),
                      ),
                      Text(
                        '${controller.saleTable.value?.totalAmount ?? 0.0}',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      )
                    ],
                  ),
                  const SizedBox(height: 10),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        'Discount (${controller.saleTable.value?.discountPercentage ?? 0.0}%)',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.w500),
                      ),
                      Text(
                        '${controller.saleTable.value?.discountAmount}',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      )
                    ],
                  ),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        'Room Service',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.w500),
                      ),
                      Text(
                        '${controller.saleTable.value?.roomServiceAmount ?? 0.0}',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      )
                    ],
                  ),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        'Tax',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.w500),
                      ),
                      Text(
                        '${controller.saleTable.value?.taxAmount ?? 0.0}',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      )
                    ],
                  ),
                  const SizedBox(height: 10),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        'Payable Amount',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      ),
                      Text(
                        '${controller.saleTable.value?.grandTotal ?? 0.0}',
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 16,
                            fontWeight: FontWeight.bold),
                      ),
                    ],
                  ),
                  const SizedBox(height: 10),
                  Row(
                    children: [
                      //Expanded(
                      //  child: GestureDetector(
                      //    onTap: () {
                      //      Get.dialog(
                      //        barrierDismissible: true,
                      //        Dialog(
                      //          backgroundColor: Colors.white,
                      //          child: DiscountPercentage(
                      //            typeToDiscount: 1,
                      //            saleId: controller.saleTable.value?.id,
                      //          ),
                      //        ),
                      //      );
                      //    },
                      //    child: Container(
                      //      height: Get.height * 0.05,
                      //      decoration: BoxDecoration(
                      //          color: ColorClass.orangeColor,
                      //          borderRadius: BorderRadius.circular(8)),
                      //      child: Row(
                      //        mainAxisAlignment: MainAxisAlignment.center,
                      //        children: [
                      //          const Icon(
                      //            Icons.discount,
                      //            color: Colors.white,
                      //          ),
                      //          const SizedBox(width: 5),
                      //          Text(
                      //            'Discount',
                      //            style: GoogleFonts.poppins(
                      //                color: Colors.white,
                      //                fontWeight: FontWeight.w600,
                      //                fontSize: 14),
                      //          )
                      //        ],
                      //      ),
                      //    ),
                      //  ),
                      //),
                      //const SizedBox(width: 5),
                      Expanded(
                        child: GestureDetector(
                          onTap: () {
                            controller.printFoodToKichen();
                          },
                          child: Container(
                            height: Get.height * 0.05,
                            decoration: BoxDecoration(
                                color: Colors.blue,
                                borderRadius: BorderRadius.circular(8)),
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
                      //const SizedBox(width: 5),
                      //Expanded(
                      //  child: Container(
                      //    height: Get.height * 0.05,
                      //    decoration: BoxDecoration(
                      //        color: Colors.blue,
                      //        borderRadius: BorderRadius.circular(8)),
                      //    child: GestureDetector(
                      //      onTap: () {
                      //        controller.printReceipt(
                      //            1, "${controller.saleTable.value?.id ?? 0}");
                      //      },
                      //      child: Row(
                      //        mainAxisAlignment: MainAxisAlignment.center,
                      //        children: [
                      //          const Icon(
                      //            Icons.print,
                      //            color: Colors.white,
                      //          ),
                      //          const SizedBox(width: 5),
                      //          Text(
                      //            'Print',
                      //            style: GoogleFonts.poppins(
                      //                color: Colors.white,
                      //                fontWeight: FontWeight.w600,
                      //                fontSize: 14),
                      //          )
                      //        ],
                      //      ),
                      //    ),
                      //  ),
                      //),
                      //IconButton(onPressed: () {}, icon: Icon(Icons.money)),

                      //const SizedBox(width: 5),
                      //Expanded(
                      //  child: Container(
                      //    height: Get.height * 0.05,
                      //    decoration: BoxDecoration(
                      //        color: ColorClass.greenColor,
                      //        borderRadius: BorderRadius.circular(8)),
                      //    child: GestureDetector(
                      //      onTap: () {
                      //        Get.put(PaymentMethodController());
                      //        Get.toNamed('sale-payment', arguments: {
                      //          'sale_table': controller.saleTable.value,
                      //        });
                      //      },
                      //      child: Row(
                      //        mainAxisAlignment: MainAxisAlignment.center,
                      //        children: [
                      //          Transform.rotate(
                      //            angle: 1.5,
                      //            child: const Icon(
                      //              Icons.arrow_circle_up_outlined,
                      //              color: Colors.white,
                      //            ),
                      //          ),
                      //          const SizedBox(width: 5),
                      //          Text(
                      //            'Payment',
                      //            style: GoogleFonts.poppins(
                      //                color: Colors.white,
                      //                fontWeight: FontWeight.w600,
                      //                fontSize: 14),
                      //          )
                      //        ],
                      //      ),
                      //    ),
                      //  ),
                      //),
                    ],
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  _saleDetailItemOld(SaleDetail saleDetail) {
    return Padding(
      padding: const EdgeInsets.all(4.0),
      child: CustomerExpansionTile(
        onTap: () {
          if (controller.saleDetailExplanded.value == saleDetail.id) {
            controller.saleDetailExplanded.value = null;
          } else {
            controller.saleDetailExplanded.value = saleDetail.id;
          }
        },
        boolValue: controller.saleDetailExplanded.value == saleDetail.id,
        headerQuantity: '${saleDetail.qty}',
        productName: saleDetail.foodDishData?.englishName ?? '',
        price: '${saleDetail.totalAmount}',
        quantityHintText: '${saleDetail.qty ?? ''}',
        discountHintText: '${saleDetail.discountPercentage}',
        productSize: saleDetail.foodDishDetailId != null
            ? saleDetail.foodDishDetailData?.englishName ?? ''
            : '',
        discount: '${saleDetail.discountAmount}',
      ),
    );
  }

  _saleDetailItem(SaleDetail saleDetail) {
    FoodDish? foodDish = saleDetail.foodDishData;
    FoodDishDetail? foodDishDetail = saleDetail.foodDishDetailData;
    return ListTile(
      selectedColor: Colors.blue,
      contentPadding:
          const EdgeInsets.only(left: 10, right: 0, top: 0, bottom: 0),
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
                  "${foodDish?.englishName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.englishName})' : ''}",
                  style: TextStyle(
                      color: saleDetail.oldQty == saleDetail.qty
                          ? Colors.red
                          : null)),
            if (foodDish?.chineseName != null)
              Text(
                  "${foodDish?.chineseName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.chineseName})' : ''}",
                  style: TextStyle(
                      color: saleDetail.oldQty == saleDetail.qty
                          ? Colors.red
                          : null)),
            if (foodDish?.khmerName != null)
              Text(
                  "${foodDish?.khmerName}${saleDetail.foodDishDetailId != null ? '(${foodDishDetail?.khmerName})' : ''}",
                  style: TextStyle(
                      color: saleDetail.oldQty == saleDetail.qty
                          ? Colors.red
                          : null)),
            if (saleDetail.remark != null)
              Text(saleDetail.remark ?? '',
                  style: TextStyle(
                      color: saleDetail.oldQty == saleDetail.qty
                          ? Colors.red
                          : null))
          ],
        ),
      ),
      subtitle: Text("${saleDetail.foodPrice} x ${saleDetail.qty} "
          "(${saleDetail.discountPercentage}%) = "
          "${saleDetail.totalAmountAfterDiscount}"),
      leading: foodDish?.foodPhoto != null
          ? CachedNetworkImage(
              imageUrl: foodDish?.foodPhotoUrl ?? '',
              width: 50,
              height: 50,
              fit: BoxFit.cover,
              errorWidget: (context, url, error) => Image.asset(
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
  }
}
