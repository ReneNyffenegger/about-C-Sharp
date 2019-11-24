//
// Found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast
// Slightly modified by me.

using System;

public class Base {
   public int num;
}

public class Derived_A : Base {
   public string txt;
}

public class Derived_B : Base {
   public string txt;
}

class Prg {

    public static void Main() {

        object b  = new Base() {num = 99};

        object da = new Derived_A() {num = 42, txt = "Hello, World"};
        object db = new Derived_B() {num = 17, txt = "Good bye"    };

     // ---------------------------------------------------------------

        try {
           Derived_B x = (Derived_B) b;
           Console.WriteLine($"x.num = {x.num}, x.txt = {x.txt}");
        }
        catch (System.InvalidCastException) {
           Console.WriteLine("Cast didn't succeed");
        }
     //
     // Cast didn't succeed
     //

     // ---------------------------------------------------------------

        try {
           Base y = (Base) da;
           Console.WriteLine($"y.num = {y.num}");
        // Console.WriteLine($"y.txt = {y.txt}"); // error CS1061: 'Base' does not contain a definition for 'txt' …
        }
        catch (System.InvalidCastException) {
           Console.WriteLine("Cast didn't succeed");
        }
     //
     // y.num = 42
     //

     // ---------------------------------------------------------------
     //
     // Derived_A z = (Derived_B) b; // error CS0029: Cannot implicitly convert type 'Derived_B' to 'Derived_A'
     //
     // ---------------------------------------------------------------

        try {
           Derived_A z = (Derived_A) db;
           Console.WriteLine($"z.num = {z.num}, z.txt = {z.txt}");
        }
        catch (System.InvalidCastException) {
           Console.WriteLine("Cast didn't succeed");
        }

     //
     // Cast didn't succeed
     //
     // ---------------------------------------------------------------
    }
}
