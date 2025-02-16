using System;
using MyLibrary;
class Program
{
  static void PrintNumbers (params int[] numbers){

    foreach (int num in numbers) {
        Console.Write(num + " all ");
    }
  }


  static void Main () 

  {

    int result = Class1.Add(1,3);
    Console.WriteLine("Add = " +result);

    int subResult = Class1.Sub(3, 2);
    Console.WriteLine("sub = "+subResult);
    PrintNumbers (1,2,3,3,4);
  }
}
