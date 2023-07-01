using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Generics.Generic_Constraints
{
    public class Utilities
    {

        //Type of constraints
        //where T : Interface
        //where T : Product
        //where T : class
        //where T : struct
        //where T : new()
        public int Max(int a,int b)
        {
            return a > b ? a : b;
        }

        //generic method inside a non generic class
        public T Max<T>(T a , T b) where T : IComparable
            
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


        public void DoSomething<T>(T value) where T : new()
        //new() constraint to have a default constructor to be able to instantiate it
        {
            //instantiate T is not available
            //var obj = new T();

            //after adding new() constraint
            var obj = new T();
        }
    }
}
