import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/reload_button.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/search_field.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/wifi_button.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class Header extends StatelessWidget {
  const Header({
    super.key,
    required this.searchController,
  });

  final TextEditingController searchController;

  @override
  Widget build(BuildContext context) {
    return Container(
      height: Get.height * 0.08,
      width: Get.width,
      decoration: const BoxDecoration(
        color: Colors.white,
        boxShadow: [
          BoxShadow(blurRadius: 8, color: Colors.black12),
        ],
      ),
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Text(
              CommonConstants.appName,
              style: GoogleFonts.poppins(
                color: Colors.black,
                fontWeight: FontWeight.bold,
                fontSize: 24,
              ),
            ),
            const SizedBox(width: 20),
            SearchField(controller: searchController),
            Expanded(
              flex: 1,
              child: Container(),
            ),
            const ReloadButton(),
            const SizedBox(width: 10),
            const WifiButton(),
            const SizedBox(width: 10),
            ElevatedButton(
                onPressed: () {},
                style: ButtonStyle(
                  backgroundColor:
                      WidgetStateProperty.all(ColorClass.orangeColor),
                  shape: WidgetStateProperty.all<RoundedRectangleBorder>(
                    RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(6.0),
                    ),
                  ),
                ),
                child: Text(
                  'Select Table',
                  style: GoogleFonts.poppins(color: Colors.white),
                )),
            const SizedBox(width: 10),
          ],
        ),
      ),
    );
  }
}
