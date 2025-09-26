import 'package:chuanmapo_flutter/app/data/shared/utils/responsive.dart';
import 'package:chuanmapo_flutter/app/modules/person_count/controllers/person_count_controller.dart';
import 'package:chuanmapo_flutter/app/modules/person_count/views/person_count_view.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../controllers/home_controller.dart';

class HomeView extends GetView<HomeController> {
  const HomeView({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Table'),
        actions: [
          IconButton(
            onPressed: () {
              controller.fetchDiningTableRepositoryData();
            },
            icon: const Icon(Icons.refresh),
          ),
          IconButton(
            onPressed: () {
              controller.logout();
            },
            icon: const Icon(Icons.logout),
          ),
        ],
      ),
      body: Obx(
        () => _buildTableGrid(context),
      ),
      // bottomNavigationBar: BottomAppBar(
      //   child: Container(
      //     height: 50,
      //     child: Row(mainAxisAlignment: MainAxisAlignment.end, children: [
      //       IconButton(onPressed: () {}, icon: const Icon(Icons.settings)),
      //     ]),
      //   ),
      // ),
    );
  }

  Widget _buildTableGrid(BuildContext context) {
    return GridView.count(
      crossAxisCount: Responsive.isMobile(context) ? 3 : 6,
      children: List.generate(controller.dining_Tables.length, (index) {
        return Card(
          child: InkWell(
            onTap: () {
              if (controller.busy_Tables
                  .contains(controller.dining_Tables[index].id)) {
                //request to api
                // Get.put(OrderMenuController(
                //     tableId: controller.dining_Tables.value[index].id,
                //     personCount:
                //         controller.dining_Tables.value[index].personCount));
                Get.offAllNamed('order-menu', arguments: {
                  'tableId': controller.dining_Tables[index].id,
                  'personCount': controller.dining_Tables[index].personCount
                });
                return;
              }
              Get.put(PersonCountController(
                  dining_table_id: controller.dining_Tables[index].id!));

              showDialog(
                  context: context,
                  builder: (context) {
                    return const Dialog(
                      child: PersonCountView(),
                    );
                  });
            },
            child: Container(
              margin: const EdgeInsets.all(10),
              alignment: Alignment.center,
              decoration: BoxDecoration(
                color: controller.busy_Tables
                        .contains(controller.dining_Tables[index].id)
                    ? Colors.red
                    : Colors.green,
                borderRadius: BorderRadius.circular(10),
              ),
              child: Text(
                controller.dining_Tables[index].englishName ?? '',
                style: const TextStyle(fontSize: 24),
              ),
            ),
          ),
        );
      }, growable: true),
    );
  }
}
