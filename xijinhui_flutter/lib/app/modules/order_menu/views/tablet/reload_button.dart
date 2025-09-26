import 'package:chuanmapo_flutter/app/data/shared/constants/icons.dart';
import 'package:flutter/material.dart';

class ReloadButton extends StatelessWidget {
  const ReloadButton({
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
        child: Padding(
          padding: const EdgeInsets.all(8.0),
          child: Image.asset(IconClass.reload),
        ),
      ),
    );
  }
}
