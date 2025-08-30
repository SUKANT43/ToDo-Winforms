import 'package:flutter/material.dart';

class CurrencyConverterMaterialPage extends StatelessWidget {
  const CurrencyConverterMaterialPage({super.key});
  @override
  Widget build(BuildContext context) {
   return const Scaffold(
    backgroundColor: Colors.blueGrey ,
     body:Center(
     child:  Column(
      mainAxisAlignment:MainAxisAlignment.center,
      children:[
        Text("0hhsdsjsdjd",
          style: TextStyle(
          fontSize:35,
          fontWeight:FontWeight.bold,
          color: Colors.white
        ),
        ),
        TextField(
        style:TextStyle (
          color:Colors.black,
          fontWeight:FontWeight.w500,
          ),
          decoration: InputDecoration(
            hintText: 'Please enter the amount in usd',
            hintStyle: TextStyle(
              color: Colors.black,
            ),
            prefixIcon:Icon(Icons.monetization_on_outlined), 
            prefixIconColor:Colors.black,
            filled:true,
            fillColor: Colors.white,
            focusedBorder: OutlineInputBorder(
              borderSide: BorderSide(
                color: Colors.red,
                width: 2.0,
                style:BorderStyle.solid,
                strokeAlign: BorderSide.strokeAlignOutside
              ),
              borderRadius: BorderRadius.all(
                Radius.circular(50),
                )
            )
          ),
        )
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