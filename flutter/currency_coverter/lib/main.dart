import 'package:flutter/material.dart';//it contains many class methods

void main(){
  runApp( MyApp());//this is for running the app
}

//MaterialApp is used for navigation 
//Types of Widgets
//1. StateLessWidgets data is immutable
//2. StateFullWidgets data is mutable data can change
//3. InheritedWidgets

//state defines how the changes looks like
class MyApp extends StatelessWidget{
  //we need to override because My app extends statelessWidget
  @override
  Widget build(BuildContext context){
    return Text(
      "hello world !!",
      textDirection: TextDirection.ltr,
      selectionColor: Color.fromARGB(0, 214, 86, 21),
    );
  }
}
