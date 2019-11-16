using System;

class Prg {

  static int f1(int i) {
     return 42/i;
  }

  static void Main() {

     try {
        Console.WriteLine(f1( 7));
        Console.WriteLine(f1( 0));
        Console.WriteLine(f1(-2));
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
