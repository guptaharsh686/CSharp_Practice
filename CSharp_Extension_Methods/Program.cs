using System;

namespace CSharp_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string paragraph = "This is a long long paragraph blah blah ....";

            var shortParagraph = paragraph.Shorten(5);
            //Shorten is an extension method

            Console.WriteLine(shortParagraph);
        }
    }
}
