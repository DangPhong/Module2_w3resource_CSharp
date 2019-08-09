using System;

namespace Ex09
{
    class Program
    {
        static double average(int a, int b, int c, int d)
        {
            double averager = (a + b + c + d)/4;
            return averager;
        }
        static void Main(string[] args)
        {
            Console.Write("average of 4 number is: ");
            Console.WriteLine(average(6, 5, 8, 9)) ;
        }
    }
}
