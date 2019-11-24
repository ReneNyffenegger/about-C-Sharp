using System;
using System.Collections;

class Coll : IEnumerable {

   public Coll() {
      Console.WriteLine("Constructor");
   }

   public void Add(int item) {
      Console.WriteLine($"adding {item}");
   }

   public IEnumerator GetEnumerator() {
   //
   // The method GetEnumerator() is required by IEnumerable.
   //
   // It is not required for this example, therefore, we
   // just return null:
   //
      return null;
   }
}

class Prg {

   static void Main() {
      Coll coll = new Coll {1, 1, 2, 3, 5, 8};
   }
}
//
// Example prints
//    Constructor
//    adding 1
//    adding 1
//    adding 2
//    adding 3
//    adding 5
//    adding 8
