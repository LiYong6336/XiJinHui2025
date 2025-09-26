import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/omenu/order_menu_body.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class OrderMenuTablet extends StatefulWidget {
  const OrderMenuTablet({super.key});

  @override
  State<OrderMenuTablet> createState() => _RootPageState();
}

class _RootPageState extends State<OrderMenuTablet> {
  int selectedIndex = 0;
  final _pages = [
    OrderMenuBody(),
    //Container(),
    Container(),
    Container(),
    Container(),
    Container(),
    Container(),
    Container(),
  ];
  final TextEditingController searchController = TextEditingController();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      // backgroundColor: Colors.grey.shade100,
      body: SafeArea(
        child: SizedBox(
          height: Get.height,
          width: Get.width,
          child: Column(
            children: [
              //Header(searchController: searchController),
              Expanded(
                child: Row(
                  children: [
                    // Container(
                    //   width: Get.width * 0.09,
                    //   height: Get.height - 92,
                    //   decoration: const BoxDecoration(
                    //     color: Colors.white,
                    //     boxShadow: [
                    //       BoxShadow(color: Colors.black12, blurRadius: 1),
                    //     ],
                    //   ),
                    //   child: Column(
                    //     children: [
                    //       sideBar(0, IconClass.home, 'Home'),
                    //       sideBar(1, IconClass.customer, 'Customers'),
                    //       sideBar(2, IconClass.tables, 'Tables'),
                    //       sideBar(3, IconClass.cashier, 'Cashier'),
                    //       sideBar(4, IconClass.orders, 'Orders'),
                    //       sideBar(5, IconClass.reports, 'Reports'),
                    //       //sideBar(6, IconClass.settings, 'Settings'),
                    //       // SizedBox(height: Get.height * 0.03),
                    //       const Spacer(),
                    //       const CircleAvatar(
                    //           radius: 30,
                    //           backgroundImage:
                    //               AssetImage('assets/images/profile.jpg')),
                    //       const SizedBox(height: 10),
                    //       GestureDetector(
                    //         onTap: () {},
                    //         child: Padding(
                    //           padding: const EdgeInsets.all(8.0),
                    //           child: Column(
                    //             mainAxisAlignment: MainAxisAlignment.center,
                    //             children: [
                    //               Image.asset(IconClass.logout,
                    //                   height: 25,
                    //                   width: 30,
                    //                   color: Colors.grey),
                    //               const SizedBox(height: 5),
                    //               Text(
                    //                 'Logout',
                    //                 style: GoogleFonts.poppins(
                    //                     fontSize: 12, color: Colors.grey),
                    //               ),
                    //             ],
                    //           ),
                    //         ),
                    //       )
                    //     ],
                    //   ),
                    // ),
                    Expanded(child: _pages[selectedIndex]),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Widget sideBar(int index, String image, String title) {
    return GestureDetector(
      onTap: () {
        setState(() {
          selectedIndex = index;
        });
      },
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Container(
          height: Get.height * 0.08,
          width: Get.width - 10,
          decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(6),
            border: Border.all(
                color: index == selectedIndex
                    ? ColorClass.orangeColor
                    : Colors.transparent,
                width: 2),
            color: index == selectedIndex
                ? ColorClass.bgOrangeColor
                : Colors.transparent,
          ),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Image.asset(image,
                  height: 25,
                  width: 30,
                  color: index == selectedIndex
                      ? ColorClass.orangeColor
                      : Colors.grey),
              const SizedBox(height: 5),
              Text(
                title,
                style: GoogleFonts.poppins(
                    fontSize: 12,
                    color: index == selectedIndex
                        ? ColorClass.orangeColor
                        : Colors.grey),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
