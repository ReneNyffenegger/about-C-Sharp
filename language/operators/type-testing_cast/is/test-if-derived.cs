//
// Found at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast
// Slightly modified by me.

using System;

public class Base {}
public class Derived_A : Base {}
public class Derived_B : Base {}

class Prg {

    public static void Main() {

        object b  = new Base();
        object da = new Derived_A();
        object db = new Derived_B();

        Console.WriteLine(b is Base     ); // True
        Console.WriteLine(b is Derived_A); // False
        Console.WriteLine(b is Derived_B); // False

        Console.WriteLine(da is Base     ); // True
        Console.WriteLine(da is Derived_A); // True

        Console.WriteLine(db is Base     ); // True
        Console.WriteLine(db is Derived_A); // False
    }
}
