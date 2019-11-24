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

        Derived_B x = b as Derived_B;
        if (x is null) {
           Console.WriteLine("Cast didn't succeed");
        }
        else {
           Console.WriteLine($"x.num = {x.num}, x.txt = {x.txt}");
        }
     //
     // Cast didn't succeed
     //

     // ---------------------------------------------------------------

        Base y = da as Base;
        if (y is null) {
           Console.WriteLine("Cast didn't succeed");
        }
        else {
           Console.WriteLine($"y.num = {y.num}");
        // Console.WriteLine($"y.txt = {y.txt}"); // error CS1061: 'Base' does not contain a definition for 'txt' …
        }

     // ---------------------------------------------------------------
     //
     // Derived_A z = b as Derived_B;             // error CS0029: Cannot implicitly convert type 'Derived_B' to 'Derived_A'
     //
     // ---------------------------------------------------------------

        Derived_A z = db as Derived_A;
        if (z is null) {
           Console.WriteLine("Cast didn't succeed");
        }
        else {
           Console.WriteLine($"z.num = {z.num}, z.txt = {z.txt}");
        }

     //
     // Cast didn't succeed
     //
     // ---------------------------------------------------------------
    }
}
