import 'package:chuanmapo_flutter/app/data/api/repository/dining_table_repository.dart';
import 'package:chuanmapo_flutter/app/data/models/response/dining_table_response.dart';
import 'package:get/get.dart';
import 'package:shared_preferences/shared_preferences.dart';

class HomeController extends GetxController {
  final DiningTableRepository diningTableRepository;

  HomeController({
    required this.diningTableRepository,
  });
  //var tableList = <DiningTableData>[].obs;
  final isLoading = false.obs;

  var dining_Tables = RxList<Dining>();
  List<int> busy_Tables = [];

  @override
  void onReady() {
    fetchDiningTableRepositoryData();
    super.onReady();
  }

  // Future fetchDiningTableRepositoryData() async {
  //   try {
  //     final res = await diningTableRepository.get_dining_table();
  //     this.tableList.value = res!.data!;
  //   } catch (e) {
  //     throw e;
  //   }
  // }

  void fetchDiningTableRepositoryData() async {
    isLoading(true);
    final todosData = await diningTableRepository.get_dining_table();
    // print(todosData.floors.toString());
    // this.floors.assignAll(todosData.floors ?? []);
    dining_Tables.value = todosData!.data!.dining ?? [];

    busy_Tables = (todosData.data?.busyTable ?? [])
        .map((e) => e.diningTableId as int)
        .toList();
    // todos.assignAll(todosData);
    isLoading(false);
  }

  void logout() {
    diningTableRepository.logout();
    Get.offAllNamed('login');
    final prefs = Get.find<SharedPreferences>();
    prefs.remove('token');
  }
}
