using System;
using System.Collections.Generic;

class Prg {

   static IEnumerable<string> words() {
      yield return "foo";
      yield return "bar";
      yield return "baz";
   }

   static void Main() {
      foreach (string word in words()) {
         Console.WriteLine(word);
      }
   }
}
