using System;

namespace Ex37
{
    class Program
    {
        //Write a C# program to check if "HP" appears at second position in a string
        //and returns the string without "HP".
        static void Main(string[] args)
        {
            string str = "dang phong";
            Console.WriteLine(str.Substring(0, 4).Equals("dang") ? str.Remove(0, 4) : str);    
        }
    }
}
