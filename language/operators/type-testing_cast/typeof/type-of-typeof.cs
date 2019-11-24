using System;

class TypeOf_typeof {
   public static void Main() {
      Console.WriteLine($"typeof(object            ).GetType().FullName = {typeof(object            ).GetType().FullName}");
      Console.WriteLine($"typeof(System.Int32      ).GetType().FullName = {typeof(System.Int32      ).GetType().FullName}");
      Console.WriteLine($"typeof(System.Type       ).GetType().FullName = {typeof(System.Type       ).GetType().FullName}");
   }
}
//
// typeof(object            ).GetType().FullName = System.RuntimeType
// typeof(System.Int32      ).GetType().FullName = System.RuntimeType
// typeof(System.Type       ).GetType().FullName = System.RuntimeType
//
