using System;

namespace Ex15
{
    class Program
    {
        static string removeChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(removeChar("CCodeGym", 1));  
        }
    }
}
