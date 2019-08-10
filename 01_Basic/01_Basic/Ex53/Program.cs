using System;

namespace Ex53
{
    class Program
    {
        static bool checkOddNumberArr(int[] arr)
        {
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            Console.WriteLine(checkOddNumberArr(arr1));
            Console.WriteLine(checkOddNumberArr(arr2));
        }
    }
}
