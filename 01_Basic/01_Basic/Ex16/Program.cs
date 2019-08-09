using System;

namespace Ex16
{
    class Program
    {
        static string swapfisrtCharLastChar(string str)
        {
            // 16. Write a C# program to create
            //a new string from a given string where the first 
            //and last characters will change their positions.
            return str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
        }
        static void Main(string[] args)
        {
            string str = "gguyen Dang PhonN";
            Console.WriteLine("Before");
            Console.WriteLine(str);
            Console.WriteLine("After");
            Console.WriteLine(swapfisrtCharLastChar(str));
        }
    }
}
