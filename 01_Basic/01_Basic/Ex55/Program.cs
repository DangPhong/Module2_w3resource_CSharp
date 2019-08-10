using System;

namespace Ex55
{
    //55. Write a C# program to find the pair of adjacent elements that has the largest product of
    // an given array which is equal to a given value. Go to the editor
    class Program
    {
        static int findMaxPair(int[] arr)
        {
            int max = arr[0] * arr[1];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] * arr[i + 1] > max)
                {
                    max = arr[i] * arr[i + 1];
                }
            }
            Console.WriteLine(max);
            return max;
        }
        static void Main(string[] args)
        {
            Console.Write("max pair in array: ");
            int[] arr = { 1, 2, 3, 5, 6, 4, 7, 8 };
            findMaxPair(arr);
        }
    }
}
