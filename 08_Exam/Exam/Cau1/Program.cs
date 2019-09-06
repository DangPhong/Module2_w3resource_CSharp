using System;

namespace Cau1
{
    class Program
    {
        public static int[][] matrix;

        public static void InitMatrix()
        {
            Console.Write("n: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            var m = int.Parse(Console.ReadLine());
            matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0}][{1}]= ", i, j);
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void DisplayArr()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
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

        public static void ShowMaxRow()
        {
            var max = Sum(matrix[0]);
            var pos = 0;
            for (int i = 1; i < matrix.Length; i++)
                         {
                if (max < Sum(matrix[i]))
                {
                    max = Sum(matrix[i]);
                    pos = i;
                }
            }
            Console.WriteLine("Hang {0} = {1} la hang co tong lon nhat", pos + 1, string.Join(" ",matrix[pos]));
        }

        static void Main(string[] args)
        {
            InitMatrix();
            DisplayArr();
            ShowMaxRow();
        }
    }
}