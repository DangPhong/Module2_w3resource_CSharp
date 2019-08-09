using System;

namespace Ex33
{
    class Program
    {
        //33. Write a C# program to check if a given positive number is
        // a multiple of 3 or a multiple of 7.
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine(num + " a multiple of 3 ");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine(num + " a  multiple of 7");

            }
            else
                Console.WriteLine(num + " not a multiple of 3 or a multiple of 7");
        }
    }
}
