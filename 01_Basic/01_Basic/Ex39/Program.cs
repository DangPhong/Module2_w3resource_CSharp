using System;

namespace Ex39
{
    //39. Write a C# program to find the largest and lowest values from three integer values.
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a, b, c: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The largest from three integer values is: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("The lowest from three integer values is: " + Math.Min(a, Math.Min(b, c)));
        }
    }
}
