using System;
using System.Collections;
using System.Collections.Generic;

class NumberGenerator :
   IEnumerable<int>   ,
   IEnumerator<int>
{

   private int cur; // The current number
   private int to ; // The last number to be returned

   public NumberGenerator(int start_, int to_) {
   //
   // When an enumerator is created, it is supposed to point to the
   //(possibly imaginary) element before the first element to be returned.
   // Therefore, we set the current element to one less than the
   // first number to be returned:
   //
      cur = start_ -1;
      to  = to_      ;
   }

   public IEnumerator<int> GetEnumerator() {
   //
   // Required by the interface IEnumerable<T>.
   //
   // Note, that the non-generic interface IEnumerable,
   // from which IEnumerable<T> derives, also requires
   // to implement a GetEnumerator() method.
   // This other method is implemented in the next
   // method and calls this method.
   //
      return this;
   }

   IEnumerator IEnumerable.GetEnumerator() {
   //
   // Detour, as described in previous method:
   //
      return GetEnumerator();
   }

   public bool MoveNext() {
   //
   // MoveNext() is required by IEnumerator from which
   // IEnumerator<T> derives.
   //
   // The method returns true to indicate that it could
   // successfully advance to the next number.
   // It returns false to indicate that has moved
   // passed the last element to be returned.
   //
      return cur++ < to;
   }

   public void Reset() {
   //
   // Required by IEnumerator from which
   // IEnumerator<T> derives.
   //
   // Reset the enumerator to its initial state.
   // This method is not needed nor called in
   // this simple example.
   //
      throw new Exception("Not needed for this example");
   }

   public int Current {
   //
   // required by IEnumerator<T> from which
   // IEnumerator derives.
   //
   // Current gets the element that the
   // enumerator currently points at.
   //
   // Note: The non-genereic IEnumerator *also* requires to
   // implement the Current property, see next property below:
   //
      get { return cur; }
   }

   object IEnumerator.Current {
   //
   // Because IEnumerator (as well as IEnumerator<T>)
   // requres the property Current to be implemented,
   // we have to to a detour here:
   //
      get { return Current; }
   }

   void IDisposable.Dispose() {
   //
   // Required because IEnumerator<T> implements
   // IDisposable
   //
   // Nothing to do in our case.
   }

}

class Prg {

   public static void Main() {

   //
   // Let foreach initialize the necessary instances and call
   // the correct methodes on them:
   //
      foreach (int i in new NumberGenerator(10, 15)) {
         Console.WriteLine(i);
      }
   }
}
