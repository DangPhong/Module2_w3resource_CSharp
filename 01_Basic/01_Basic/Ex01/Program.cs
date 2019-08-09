using System;

namespace Ex01
{
    class Program
    {
       // 1. Write a C# Sharp program to print Hello and your name in a separate line.

        static void Main(string[] args)
        {
            Console.Write("enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0} ", name);
        }
    }
}
