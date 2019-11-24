using System;

public class OBJ {

   private int    i_;
   private string s_;
   private float  f_;

   public int i {
          get { return i_;}
          set { i_ = value;
                 Console.WriteLine($"i_ was set to {i_}");
              }
   }

   public string s {
          get { return s_;}
          set { s_ = value;
                 Console.WriteLine($"s_ was set to {s_}");
              }
   }

   public float f {
          get { return f_;}
          set { f_ = value;
                 Console.WriteLine($"f_ was set to {f_}");
              }
   }


   public OBJ() {
      Console.WriteLine("Constructor without argument");
   }

   public OBJ(int i) {
      Console.WriteLine($"Constructor with int argument {i}");
      i_ = i;
   }

   public OBJ(string s) {
      Console.WriteLine($"Constructor with string argument {s}");
      s_ = s;
   }

   public OBJ(float f) {
      Console.WriteLine($"Constructor with float argument {f}");
      f_ = f;
   }


}

class Prg {

   static void Main() {
      OBJ obj_1 = new OBJ();
   //
   // Constructor without argument


      OBJ obj_2 = new OBJ() { i = 42, s = "Hello world" };
   //
   // Constructor without argument
   // i_ was set to 42
   // s_ was set to Hello world


      OBJ obj_3 = new OBJ("ninty-nine") { i = 99, f = 9.9F};
   //
   // Constructor with string argument ninty-nine
   // i_ was set to 99
   // f_ was set to 9.9
   }

}
