using System;

class Prg {

   static void Main() {
      var anon = new {num = 42, txt = "Hello world"};

      Console.WriteLine($"num = {anon.num}, txt = {anon.txt}");
   }
}
