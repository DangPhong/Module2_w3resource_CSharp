using System;

namespace Cau1
{
    class Program
    {
        public static void InitMatrix(int[,] arr, int n, int m)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("nhap phan tu [{0}][{1}]= ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Mang da nhap: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static int Sum(int[] arr)
        {
            int sum = 0;
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int MaxRow(int[,] arr, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += arr[m,i];
            }
            return sum;
        }
        public static int ShowMaxRow(int[,] arr, int n, int m)
        {
            int sum = 0;
            
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr2 = new int[n, m];
            InitMatrix(arr2, n, m);
            Console.WriteLine("---------------------");
            //Console.WriteLine("Tong cua mang mot chieu la ");

        }
    }
}
