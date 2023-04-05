using System;

class Program{
  static void Main(string[] args){    
    ReversePrintx10();
  }

  //ArrayDemo_ReversePrintx10--------------------------------------
  static void ReversePrintx10(){
    int[] num = new int[10];
    num[10] = 9;
    Console.WriteLine(num[10]);
    for(int i = 0; i <= 9; i++){
      num[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 9; i >= 0; i--){
      Console.WriteLine(num[i]);
    }
  }
  //ArrayDemo_ReversePrintx10-END----------------------------------
}