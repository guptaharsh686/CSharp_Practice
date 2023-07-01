using System;
using CSharp_Generics.Basic;

namespace CSharp_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Basic
            var numberList = new GenericList<int>();
            numberList.Add(10);


            var bookList = new GenericList<Book>();
            bookList.Add(new Book("a", "5454"));


            var dict = new GenericDictionary<int, string>();
            dict.Add(1, "sdad");

            //Generic Constraints

            // Constraint on value
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value" + number.HasValue);
            Console.WriteLine("Value" + number.GetValueOrDefault());


            var number2 = new Nullable<int>();
            Console.WriteLine("Has value" + number2.HasValue);
            Console.WriteLine("Value" + number2.GetValueOrDefault());

        }
    }
}
