import 'package:flutter/material.dart';//it contains many class methods

void main(){
  runApp(const MyApp());//this is for running the app
}

//MaterialApp is used for navigation 
//Types of Widgets
//1. StateLessWidgets data is immutable
//2. StateFullWidgets data is mutable data can change
//3. InheritedWidgets

//state defines how the changes looks like
class MyApp extends StatelessWidget{
  const MyApp({super.key});//const tells to dont create the app all time and super.key means it allocatte some unique value and allocate in widget tree
  //we need to override because My app extends statelessWidget
  @override
  Widget build(BuildContext context){
    return const Text(
      "hello world !!",
      textDirection: TextDirection.ltr,
      selectionColor: Color.fromARGB(0, 214, 86, 21),
    );
  }
}
