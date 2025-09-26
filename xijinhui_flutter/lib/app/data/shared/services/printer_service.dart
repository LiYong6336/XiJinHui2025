import 'dart:io';
import 'package:esc_pos_utils_plus/esc_pos_utils_plus.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_pos_printer_platform_image_3_sdt/flutter_pos_printer_platform_image_3_sdt.dart';
import 'package:image/image.dart' as img;
import 'package:screenshot/screenshot.dart';

class PrinterModel {
  int? id;
  String? deviceName;
  String? address;
  String? port;
  String? vendorId;
  String? productId;
  bool? isBle;

  PrinterType? typePrinter;
  bool? state;

  PrinterModel(
      {this.deviceName,
      this.address,
      this.port,
      this.state,
      this.vendorId,
      this.productId,
      this.typePrinter = PrinterType.bluetooth,
      this.isBle = false});

  PrinterModel.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    deviceName = json['deviceName'];
    address = json['printer_ip_address'];
    port = json['port'];
    vendorId = json['vendorId'];
    productId = json['productId'];
    isBle = json['isBle'];
    typePrinter = printerType(json['printer_type']);
    state = json['state'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    // data['printer_brand'] = this.printerBrand;
    data['deviceName'] = deviceName;
    data['printer_ip_address'] = address;
    data['port'] = port;
    data['isBle'] = isBle;
    data['printer_type'] = printerType;
    data['vendorId'] = vendorId;
    data['productId'] = productId;
    data['isBle'] = isBle;
    return data;
  }

  // convert typePrinter to enum PrinterType
  PrinterType printerType(String pType) {
    switch (pType) {
      case 'bluetooth':
        return PrinterType.bluetooth;
      case 'usb':
        return PrinterType.usb;
      default:
        return PrinterType.network;
    }
  }
}

class PrinterServcie {
  ///======================POS PRINTER VARIABLES======================
  ScreenshotController screenshotController = ScreenshotController();

  PrinterModel? selectedPrinter;
  List<int>? pendingTask;
  var printerManager = PrinterManager.instance;
  final _reconnect = false;
  final BTStatus _currentStatus = BTStatus.none;

  ///======================POS PRINTER VARIABLES======================

  final Widget widget;
  final PrinterModel printer;

  PrinterServcie({required this.widget, required this.printer});

  Future<void> print(BuildContext context) async {
    // double pixelRatio = MediaQuery.of(context).devicePixelRatio;

    final capturedImage = await screenshotController.captureFromWidget(
      widget,
      // pixelRatio: 1,
      targetSize: const Size(600, 3000),
      //   // Use the captured context here
      delay: const Duration(milliseconds: 100),
    );

    _printReceipt(capturedImage);
  }

  Future<void> _printReceipt(Uint8List imageData) async {
    final profile = await CapabilityProfile.load();
    final generator = Generator(PaperSize.mm80, profile);
    List<int> bytes = [];
    final img.Image? image = img.decodeImage(imageData);
    bytes += generator.imageRaster(image!);

    _printEscPos(bytes, generator, printer);
  }

  void _printEscPos(
      List<int> bytes, Generator generator, PrinterModel printer) async {
    var bluetoothPrinter = printer;

    switch (bluetoothPrinter.typePrinter) {
      case PrinterType.usb:
        bytes += generator.feed(2);
        bytes += generator.cut();
        await printerManager.connect(
            type: bluetoothPrinter.typePrinter!,
            model: UsbPrinterInput(
                name: bluetoothPrinter.deviceName,
                productId: bluetoothPrinter.productId,
                vendorId: bluetoothPrinter.vendorId));
        pendingTask = null;
        break;
      case PrinterType.bluetooth:
        bytes += generator.cut();
        await printerManager.connect(
            type: bluetoothPrinter.typePrinter!,
            model: BluetoothPrinterInput(
                name: bluetoothPrinter.deviceName,
                address: bluetoothPrinter.address!,
                isBle: bluetoothPrinter.isBle ?? false,
                autoConnect: _reconnect));
        pendingTask = null;
        if (Platform.isAndroid) pendingTask = bytes;
        break;
      case PrinterType.network:
        bytes += generator.feed(2);
        bytes += generator.cut();
        await printerManager.connect(
            type: bluetoothPrinter.typePrinter!,
            model: TcpPrinterInput(ipAddress: bluetoothPrinter.address!));
        break;
      default:
    }
    if (bluetoothPrinter.typePrinter == PrinterType.bluetooth &&
        Platform.isAndroid) {
      if (_currentStatus == BTStatus.connected) {
        printerManager.send(type: bluetoothPrinter.typePrinter!, bytes: bytes);
        pendingTask = null;
      }
    } else {
      printerManager.send(type: bluetoothPrinter.typePrinter!, bytes: bytes);
    }
  }
}
