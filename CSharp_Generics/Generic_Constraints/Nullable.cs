using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Generics.Generic_Constraints
{
    public class Nullable<T> where T : struct
        //constraint to a value type
        //we are trying to give value types the ability to be nullable
    {

        private Object _value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T getValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }
}
