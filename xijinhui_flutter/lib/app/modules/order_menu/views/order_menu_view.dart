import 'package:chuanmapo_flutter/app/data/shared/utils/responsive.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/bill_list_view.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/food_dish_view.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/views/tablet/order_menu_tablet.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../controllers/order_menu_controller.dart';

class OrderMenuView extends GetView<OrderMenuController> {
  static const TextStyle optionStyle =
      TextStyle(fontSize: 30, fontWeight: FontWeight.bold);
  static const List<Widget> _widgetOptions = <Widget>[
    FoodDishView(),
    BillListView(),
  ];
  const OrderMenuView({super.key});
  @override
  Widget build(BuildContext context) {
    if (Responsive.isDesktop(context) || Responsive.isTablet(context)) {
      return const OrderMenuTablet();
    }
    return Scaffold(
      body: Obx(() => _widgetOptions[controller.selectedIndex.value]),
      bottomNavigationBar: Obx(() => BottomNavigationBar(
              items: const <BottomNavigationBarItem>[
                BottomNavigationBarItem(
                  icon: Icon(Icons.home),
                  label: 'Food List',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.business),
                  label: 'Bill',
                ),
              ],
              currentIndex: controller.selectedIndex.value,
              selectedItemColor: Colors.amber[800],
              onTap: (int value) {
                //onClicked(value);
                controller.selectedIndex.value = value;
              })),
    );
  }
}
