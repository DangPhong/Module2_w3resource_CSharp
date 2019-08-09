using System;

namespace Ex32
{
    // Write a C# program to create a new string of four copies, 
    // taking last four characters from a given string.
    // If the length of the given string is less than 4 return the original one.
    class Program
    {
        static void Main(string[] args)
        {
            string str = "i love you";
            int length = str.Length;
            string sub = str.Substring(length - 4, 4);
            Console.WriteLine(length > 4 ? sub + sub + sub : str);

        }
    }
}
