using System;

class Prg {

  static int calc(int i) {
     return 42/i;
  }

  static void Main() {

     try {
        Console.WriteLine(calc( 7));
        Console.WriteLine(calc( 0));
        Console.WriteLine(calc(-2));
     }
  //
  // Note the order of the catch blocks:
  //
     catch (DivideByZeroException ex) {
        Console.WriteLine($"Divide by zero excpetion: {ex.Message}");
     }
     catch (Exception ex) {
        Console.WriteLine($"general exception: {ex.Message}");
     }
  }
}
