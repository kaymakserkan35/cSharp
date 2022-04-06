using System;

namespace thiskeyword
{
    public static class stringextensions
    {
        public static string mymethod(this string mystring)
        {

            return mystring + "...";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string mytext = "txt";
            var result = mytext.mymethod();
            Console.WriteLine();
        }
    }
}
