using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Extension_Methods
{
    public static class StringExtension
    {
        //extension method must be public static and must have first parameter of type of instance object which is calling it 
        public static string Shorten(this string str,int noOfWords)
        {
            if(noOfWords <= 0)
            {
                return "";
            }

            var words = str.Split(' ');
            var reqWords = new List<string>();

            for(int i = 0; i < noOfWords; i++)
            {
                reqWords.Add(words[i]);
            }

            string vs = "";
            foreach (var item in reqWords.ToArray())
            {
                vs = vs + item;
                vs = vs + ' ';
            }

            return vs;
        }
    }
}
