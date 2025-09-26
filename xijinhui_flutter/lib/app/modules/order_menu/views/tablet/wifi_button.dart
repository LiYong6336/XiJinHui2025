import 'package:chuanmapo_flutter/app/data/shared/shared.dart';
import 'package:flutter/material.dart';

class WifiButton extends StatelessWidget {
  const WifiButton({
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {},
      child: Container(
        width: 50,
        height: 50,
        decoration: BoxDecoration(
            color: Colors.grey.shade50,
            borderRadius: BorderRadius.circular(12)),
        child: const Padding(
          padding: EdgeInsets.all(8.0),
          child: Icon(
            Icons.wifi,
            color: ColorClass.orangeColor,
          ),
        ),
      ),
    );
  }
}
