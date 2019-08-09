using System;

namespace Ex18
{
    class Program
    {
        //18. Write a C# program to check two given integers and return true
        // if one is negative and one is positive.
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((first < 0 && second > 0) || (first > 0 && second < 0));
        }
    }
}
