using System;

namespace Ex01
{
    class Program
    {
        // 1. Write a C# Sharp program to print Hello and your name in a separate line.

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("truoc khi doi");
            Console.WriteLine("a=" + num1);
            Console.WriteLine("b=" + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("sau khi doi");
            Console.WriteLine("a=" + num1);
            Console.WriteLine("b=" + num2);
        }
    }
}
