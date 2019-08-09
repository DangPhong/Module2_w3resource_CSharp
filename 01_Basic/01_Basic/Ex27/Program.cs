using System;

namespace Ex27
{
    // 27. Write a C# program and compute the sum of the digits of an integer.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                // tach so hang don vi roi cong vao bien num
                sum += num % 10;

                //xoa hang don vi 
                num /= 10;
            }    
            Console.WriteLine(sum);
        }
    }
}
