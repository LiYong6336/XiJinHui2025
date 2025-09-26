class DiningTableResponse {
  bool? success;
  String? message;
  DiningTableData? data;

  DiningTableResponse({this.success, this.message, this.data});

  DiningTableResponse.fromJson(Map<String, dynamic> json) {
    success = json['success'];
    message = json['message'];
    data = json['data'] != null ? DiningTableData.fromJson(json['data']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['success'] = success;
    data['message'] = message;
    if (this.data != null) {
      data['data'] = this.data!.toJson();
    }
    return data;
  }
}

class DiningTableData {
  List<Dining>? dining;
  List<BusyTable>? busyTable;

  DiningTableData({this.dining, this.busyTable});

  DiningTableData.fromJson(Map<String, dynamic> json) {
    if (json['dining'] != null) {
      dining = <Dining>[];
      json['dining'].forEach((v) {
        dining!.add(Dining.fromJson(v));
      });
    }
    if (json['busyTable'] != null) {
      busyTable = <BusyTable>[];
      json['busyTable'].forEach((v) {
        busyTable!.add(BusyTable.fromJson(v));
      });
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    if (dining != null) {
      data['dining'] = dining!.map((v) => v.toJson()).toList();
    }
    if (busyTable != null) {
      data['busyTable'] = busyTable!.map((v) => v.toJson()).toList();
    }
    return data;
  }
}

class Dining {
  int? id;
  String? diningTableCode;
  String? englishName;
  String? chineseName;
  String? khmerName;
  String? remark;
  int? personCount;
  String? taxPercentage;
  String? taxFixPrice;
  String? roomServicePercentage;
  String? roomServiceFixPrice;
  bool? isBroken;
  bool? isEnable;
  int? calculationType;
  int? flagStatus;
  int? diningFloorId;

  Dining(
      {this.id,
      this.diningTableCode,
      this.englishName,
      this.chineseName,
      this.khmerName,
      this.remark,
      this.personCount,
      this.taxPercentage,
      this.taxFixPrice,
      this.roomServicePercentage,
      this.roomServiceFixPrice,
      this.isBroken,
      this.isEnable,
      this.calculationType,
      this.flagStatus,
      this.diningFloorId});

  Dining.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    diningTableCode = json['dining_table_code'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    remark = json['remark'];
    personCount = json['person_count'];
    taxPercentage = json['tax_percentage'];
    taxFixPrice = json['tax_fixPrice'];
    roomServicePercentage = json['room_service_percentage'];
    roomServiceFixPrice = json['room_service_fixPrice'];
    isBroken = json['is_broken'];
    isEnable = json['is_enable'];
    calculationType = json['calculation_type'];
    flagStatus = json['flag_status'];
    diningFloorId = json['dining_floor_id'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['dining_table_code'] = diningTableCode;
    data['english_name'] = englishName;
    data['chinese_name'] = chineseName;
    data['khmer_name'] = khmerName;
    data['remark'] = remark;
    data['person_count'] = personCount;
    data['tax_percentage'] = taxPercentage;
    data['tax_fixPrice'] = taxFixPrice;
    data['room_service_percentage'] = roomServicePercentage;
    data['room_service_fixPrice'] = roomServiceFixPrice;
    data['is_broken'] = isBroken;
    data['is_enable'] = isEnable;
    data['calculation_type'] = calculationType;
    data['flag_status'] = flagStatus;
    data['dining_floor_id'] = diningFloorId;
    return data;
  }
}

class BusyTable {
  int? statusCode;
  int? diningTableId;
  String? saleDate;
  int? personCount;

  BusyTable(
      {this.statusCode, this.diningTableId, this.saleDate, this.personCount});

  BusyTable.fromJson(Map<String, dynamic> json) {
    statusCode = json['status_code'];
    diningTableId = json['dining_table_id'];
    saleDate = json['sale_date'];
    personCount = json['person_count'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['status_code'] = statusCode;
    data['dining_table_id'] = diningTableId;
    data['sale_date'] = saleDate;
    data['person_count'] = personCount;
    return data;
  }
}
