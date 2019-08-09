using System;

namespace Ex05
{
    class Program
    {
        //5. Write a C# Sharp program to swap two numbers

        public static void swap(int a, int b)
        {
            Console.WriteLine("before swap");
            Console.WriteLine("a= {0} va b = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap");
            Console.WriteLine("a= {0} va b = {1}", a, b);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            swap(a, b);
        }
    }
}
