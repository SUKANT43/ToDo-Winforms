import 'package:flutter/material.dart';

class CurrencyConverterMaterialPage extends StatelessWidget {
  const CurrencyConverterMaterialPage({super.key});
  @override
  Widget build(BuildContext context) {
   return const Scaffold(
     body:Center(
     child:  Column(
      mainAxisAlignment:MainAxisAlignment.center,
      children:[
        Text("0",style: TextStyle(
          fontSize:35,
          fontWeight:FontWeight.bold,
          color: Color.fromARGB(255, 122, 16, 16)
        ),
        ),
      ],
     )
    )
    );
  }
}
/*
main axis-verticle |
cross axis- -
column is going to return list so we can achive multiple values on it
 */