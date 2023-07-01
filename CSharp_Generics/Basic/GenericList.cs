using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Generics.Basic
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }



        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
