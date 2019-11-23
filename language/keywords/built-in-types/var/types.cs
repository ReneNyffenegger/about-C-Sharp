using System;

class Prg {

   static void Main() {

     var a = 42     ; Console.WriteLine(a.GetType().FullName); // System.Int32
     var b = 42.42  ; Console.WriteLine(b.GetType().FullName); // System.Double
     var c = 42.42f ; Console.WriteLine(c.GetType().FullName); // System.Single
     var d = 42L    ; Console.WriteLine(d.GetType().FullName); // System.Int64

  //
  // var is especially useful when creating an anonymous type:
  //
     var e = new { num = 42, txt = "Hello world" };
     Console.WriteLine(e.GetType().FullName); // <>f__AnonymousType0`2[[System.Int32 … ] , [System.String … ]]

   }

}
