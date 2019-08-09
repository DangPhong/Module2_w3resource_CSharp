using System;

namespace Ex26
{
    // Write a C# program to compute the sum of the first 500 prime numbers.
    class Program
    {
        static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {

            long sum = 0;
            int count = 0;
            int num = 2;
            while (count < 500)
            {
                if (isPrime(num))
                {
                    sum += num;
                    count++;
                }
                num++;
            }
            Console.Write("Tong cua 500 so nguyen to dau tien la: " + sum);
        }
    }
}
