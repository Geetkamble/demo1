using System;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "Geeta ";
            string Lname = "Kamble";

            string name = string.Concat(fname, Lname);
            Console.WriteLine(name);

            string str = "Hello World";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
        }
    }
}
