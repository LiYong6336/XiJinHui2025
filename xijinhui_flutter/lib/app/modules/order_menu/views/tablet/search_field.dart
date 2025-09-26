import 'package:chuanmapo_flutter/app/data/shared/constants/icons.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';

class SearchField extends StatelessWidget {
  const SearchField({
    super.key,
    required this.controller,
  });
  final TextEditingController controller;
  @override
  Widget build(BuildContext context) {
    return Expanded(
        child: TextFormField(
      controller: controller,
      decoration: InputDecoration(
          filled: true,
          fillColor: Colors.grey.shade50,
          suffixIcon: Padding(
            padding: const EdgeInsets.all(8.0),
            child: Image.asset(
              IconClass.search,
              width: 50,
              height: 0,
            ),
          ),
          contentPadding: const EdgeInsets.only(left: 10, right: 10),
          border: OutlineInputBorder(
            borderRadius: BorderRadius.circular(6),
            borderSide: BorderSide(color: Colors.grey.shade50),
          ),
          enabledBorder: OutlineInputBorder(
            borderRadius: BorderRadius.circular(6),
            borderSide: BorderSide(color: Colors.grey.shade50),
          ),
          hintText: 'Search products.....',
          hintStyle: GoogleFonts.poppins(color: Colors.black)),
    ));
  }
}
