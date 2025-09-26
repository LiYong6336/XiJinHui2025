class DiningTable {
  int? id;
  String? diningTableCode;
  String? englishName;
  String? chineseName;
  String? khmerName;
  String? remark;
  int? personCount;
  double? taxPercentage;
  double? taxFixPrice;
  double? roomServicePercentage;
  double? roomServiceFixPrice;
  bool? isBroken;
  bool? isEnable;
  int? calculationType;
  int? flagStatus;
  int? diningFloorId;

  DiningTable(
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

  DiningTable.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    diningTableCode = json['dining_table_code'];
    englishName = json['english_name'];
    chineseName = json['chinese_name'];
    khmerName = json['khmer_name'];
    remark = json['remark'];
    personCount = json['person_count'];
    taxPercentage = double.tryParse("${json['tax_percentage'] ?? 0}");
    taxFixPrice = double.tryParse("${json['tax_fixPrice'] ?? 0}");
    roomServicePercentage =
        double.tryParse("${json['room_service_percentage'] ?? 0}");
    roomServiceFixPrice =
        double.tryParse("${json['room_service_fixPrice'] ?? 0}");
    isBroken = bool.tryParse("${json['is_broken'] ?? ''}");
    isEnable = bool.tryParse("${json['is_enable'] ?? ''}");
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
