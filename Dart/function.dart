void main(){
  print(singleReturn());
  print(MultipleReturn());
  print(MultipleReturn().$1);
  var(age,male,greet)=MultipleReturn();
  print(age);
}

int singleReturn(){
  return 10;
}

(int,bool,String) MultipleReturn(){
  return (10,true,"hi");
}

//string _hello;--->this is private field