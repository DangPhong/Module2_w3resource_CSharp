using System;

namespace Ex13
{
    class Program
    {
        // 13. Write a C# program that takes a number as input and 
        // then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }

        }
    }
}
