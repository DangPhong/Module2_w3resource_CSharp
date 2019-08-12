using System;

namespace Ex58
{
    // Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range
    class Program
    {
       
        public static int checkInterger(int[] arr)
        {
            Array.Sort(arr);
            var min = arr[0];
            var max = arr[arr.Length - 1];
            var count = 0;
            
            for (int i = min; i < max; i++)
            {
                if (!find(arr, i))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool find(int[]arr, int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == index)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] B = { 5, 9, 4, 7, 3,44 };
            Console.WriteLine(checkInterger(B));


        }
    }
}
