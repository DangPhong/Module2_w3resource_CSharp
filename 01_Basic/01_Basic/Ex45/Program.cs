using System;

namespace Ex45
{
    //Write a C# program to count a specified number in a given array of integers.
    class Program
    {
        static int countNumber(int num, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 1, 1, 1, 1, 2, 3, 6, 4 };
            countNumber(1, arr);
        }
    }
}
