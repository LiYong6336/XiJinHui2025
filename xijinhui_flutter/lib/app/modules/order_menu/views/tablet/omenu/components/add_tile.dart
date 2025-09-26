import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class AddTile extends StatelessWidget {
  const AddTile({
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      height: Get.height * 0.08,
      // width: Get.width,
      decoration: BoxDecoration(
          color: ColorClass.bgOrangeColor,
          borderRadius: BorderRadius.circular(4)),
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Text(
              'Add',
              style: GoogleFonts.poppins(
                  color: Colors.black,
                  fontSize: 16,
                  fontWeight: FontWeight.bold),
            ),
            const Spacer(),
            Text(
              'Discount',
              style: GoogleFonts.poppins(
                  color: ColorClass.orangeColor,
                  fontSize: 16,
                  fontWeight: FontWeight.bold),
            ),
            const SizedBox(width: 10),
            Text(
              'Coupon Code',
              style: GoogleFonts.poppins(
                  color: ColorClass.orangeColor,
                  fontSize: 16,
                  fontWeight: FontWeight.bold),
            ),
            const SizedBox(width: 10),
            Text(
              'Note',
              style: GoogleFonts.poppins(
                  color: ColorClass.orangeColor,
                  fontSize: 16,
                  fontWeight: FontWeight.bold),
            ),
          ],
        ),
      ),
    );
  }
}
