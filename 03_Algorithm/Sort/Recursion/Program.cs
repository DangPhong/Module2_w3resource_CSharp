using System;

namespace Recursion
{
    #region Đệ qui

    #endregion
    class Program
    {
        //tính giai thừa
        public static long factorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

        // khử đệ quy
        public static long factorial2(int n)
        {
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }

        // dãy fibonacy
        public static int fibonacy(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return fibonacy(n - 1) + fibonacy(n - 2);
        }

        // khử đệ quy
        public static int fibonacy2(int n)
        {
            return 0;
        }

        // tính tổng mảng đệ quy
        public static int GetSum(int[] arr, int n)
        {
            if (n == 0)
                return 0;
            return GetSum(arr, n - 1) + arr[n - 1];

        }
        static void Main(string[] args)
        {

            //Console.WriteLine(factorial(0));
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(fibonacy(i));
            //}
            int[] arr = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6 };
            Console.WriteLine("sum of arr is {0}", GetSum(arr, arr.Length));
        }


    }
}
