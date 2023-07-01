using CSharp_Generics.Generic_Constraints;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Generics.Basic
{
    class Book : Product
    {
        private string isbn;

        public Book(string isbn, string title)
        {
            this.isbn = isbn;
        }
    }
}
