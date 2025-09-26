import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../controllers/person_count_controller.dart';

class PersonCountView extends GetView<PersonCountController> {
  const PersonCountView({super.key});
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(10.0),
      alignment: Alignment.center,
      width: 320,
      height: 400,
      child: SingleChildScrollView(
        child: Column(
          mainAxisSize: MainAxisSize.min,
          //mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Text("Person Count",
                style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
            Wrap(
              spacing: 1.0, // gap between adjacent chips
              runSpacing: 1.0, // gap between lines
              direction: Axis.horizontal,
              children: [
                for (var i = 0; i < 20; i++)
                  Container(
                    padding: const EdgeInsets.all(8.0),
                    width: 70,
                    height: 50,
                    child: ElevatedButton(
                      child: Text(
                        '${i + 1}',
                        style: const TextStyle(fontSize: 16.0),
                      ),
                      onPressed: () {
                        Get.offAllNamed('order-menu', arguments: {
                          'tableId': controller.dining_table_id,
                          'personCount': i + 1
                        });
                      },
                    ),
                  )
              ],
            ),
          ],
        ),
      ),
    );
  }
}
