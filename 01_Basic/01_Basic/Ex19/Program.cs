using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to compute the sum of two given integers,
            //if two values are equal then return the triple of their sum.
            Console.Write("enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            int second = int.Parse(Console.ReadLine());
            int sum = first + second;
            int sum3 = first * 3;

            Console.WriteLine(first == second ? sum3 : sum);
        }
    }
}
