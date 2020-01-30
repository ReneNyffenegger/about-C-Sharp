using System;
using System.Runtime.InteropServices;
 
namespace tq84 {

  class Program {
  
      [DllImport(
#if CALLEE_X86 
       @"callee_x86.dll"                                ,
#else
       @"callee_x64.dll"                                ,
#endif
         CallingConvention = CallingConvention.Cdecl,
         EntryPoint        = "times_5"
      )]
      private static extern int timesFive(int a);
 
      static void Main(string[] args) {
         int multiplied = timesFive(7);
         Console.WriteLine(multiplied);
      }
   }
}
