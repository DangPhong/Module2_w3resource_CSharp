using System;

namespace Ex31
{
    //31. Write a C# program to multiply corresponding elements of two arrays of integers.
    class Program
    {
        static void multiphyTwoArrays(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + "\t");
            }
        }
        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 2, 2, 2, 2 };

            multiphyTwoArrays(arr1, arr2);
        }
    }
}
