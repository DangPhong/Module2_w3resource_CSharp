using System;

namespace Ex08
{
    class Program
    {
        //8. Write a C# Sharp program that takes a number as input and print its multiplication table.
        static void Main(string[] args)
        {
            int result;
            Console.Write("enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("multiplication table of {0} ", number);
            for (int i = 0; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }
        }
    }
}
