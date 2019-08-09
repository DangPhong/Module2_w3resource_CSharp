using System;

namespace Ex2
{
    class Program
    {
        public static double getSum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getSum(6, 5)); 
        }
    }
}
