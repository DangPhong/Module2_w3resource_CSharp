using System;

namespace Ex47
{
    class Program
    {
        static int getSum(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(getSum(arr));
        }
    }
}
