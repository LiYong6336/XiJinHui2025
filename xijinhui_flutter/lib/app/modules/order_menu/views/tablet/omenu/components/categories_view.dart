import 'package:chuanmapo_flutter/app/data/models/category_model.dart';
import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:chuanmapo_flutter/app/modules/order_menu/controllers/order_menu_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:google_fonts/google_fonts.dart';

class CategoriesView extends StatelessWidget {
  var controller = Get.find<OrderMenuController>();
  CategoriesView({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: Obx(
        () => Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: List.generate(
            controller.categories.length,
            (index) {
              CategoryModel category = controller.categories[index];
              return Padding(
                padding: const EdgeInsets.symmetric(horizontal: 0, vertical: 0),
                child: GestureDetector(
                  onTap: () {
                    controller.selectedCategory.value = category;
                    controller.filterFoodDishByCategory(category.id);
                  },
                  child: Container(
                    width: Get.width * 0.08,
                    padding: EdgeInsets.symmetric(
                        horizontal:
                            category.id == controller.selectedCategory.value?.id
                                ? 4
                                : 0),
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(8),
                      color:
                          category.id == controller.selectedCategory.value?.id
                              ? ColorClass.bgOrangeColor
                              : Colors.white,
                      border: Border.all(
                        color:
                            category.id == controller.selectedCategory.value?.id
                                ? ColorClass.orangeColor
                                : Colors.white,
                        width: 2,
                      ),
                    ),
                    child: Center(
                      child: Text(
                        controller.categories[index].englishName ?? '',
                        overflow: TextOverflow.ellipsis,
                        maxLines: 1,
                        style: GoogleFonts.poppins(
                            color: Colors.black,
                            fontSize: 14,
                            fontWeight: FontWeight.w500),
                      ),
                    ),
                  ),
                ),
              );
            },
          ),
        ),
      ),
    );
  }
}
