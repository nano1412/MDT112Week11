﻿using System;

class Program{
  static void Main(string[] args){    
    // ReversePrintx10();
    // StudentHeight();
    // EvenArray();
    SortArray();
  }

  //ArrayDemo_ReversePrintx10--------------------------------------
  static void ReversePrintx10(){
    int[] num = new int[10];
    for(int i = 0; i <= 9; i++){
      num[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 9; i >= 0; i--){
      Console.WriteLine(num[i]);
    }
  }
  //ArrayDemo_ReversePrintx10-END----------------------------------

  //StudentHeight--------------------------------------------------
  static void StudentHeight(){
    // declear Array
    double[] studentHeightcm = new double[15];

    // loop input
    for(int i = 0; i < 15; i++){
      Console.Write("Student No.{0} height(cm): ", i+1);
      studentHeightcm[i] = double.Parse(Console.ReadLine());
    }

    // loop output
    for(;1 == 1;){
      Console.Write("student number: ");
      int wantedstudent = int.Parse(Console.ReadLine());

      if(wantedstudent >=1 && wantedstudent <=15){
        Console.WriteLine("student No.{0} height = {1} cm", wantedstudent, studentHeightcm[wantedstudent - 1]);
      } else {
        break;
      }

    }
    Console.WriteLine("Goodbye");
  }
  //StudentHeight-END----------------------------------------------

  //EvenArray------------------------------------------------------ 
  static void EvenArray(){
    int size = int.Parse(Console.ReadLine());
    int[] num = new int[size];

    for(int i = 0; i < num.Count(); i++){
      Console.Write("number {0}: ", i+1);
      num[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 0; i < num.Count(); i++){
      if(num[i] % 2 == 0){
        Console.WriteLine(num[i]);
      }
    }
  }
  //EvenArray-END--------------------------------------------------

  //SortArray------------------------------------------------------
  static void SortArray(){
    int size = int.Parse(Console.ReadLine());
    int[] num = new int[size];

    for(int i = 0; i < num.Count(); i++){
      Console.Write("number {0}: ", i+1);
      num[i] = int.Parse(Console.ReadLine());
    }

    // bubble sort
    for(;size >=0; size--){
      for(int i = 1; i < num.Count(); i++){
        if(num[i] > num[i-1]){
          int x = num[i-1];
          num[i-1] = num[i];
          num[i] = x;
        }
      }
    }
    
    for(int i = 0; i < num.Count();i++){
      Console.WriteLine(num[i]);
    }
  }
  //SortArray-END--------------------------------------------------

}