using System;

static class APP {

   static void Main() {
       foreach (int number in SomeNumbers()) {
           Console.Write(number.ToString() + " ");
       }
       Console.WriteLine();
   }

   static System.Collections.IEnumerable SomeNumbers() {
       yield return 3;
       yield return 5;
       yield return 8;
   }
}
