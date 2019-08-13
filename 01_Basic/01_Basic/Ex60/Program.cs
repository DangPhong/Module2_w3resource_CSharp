using System;

namespace Ex60
{
    //Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those
    //integers which are located below an intger of value 0. 
    //Sample Example:
    //matrix = [[0, 2, 3, 2],
    //[0, 6, 0, 1],
    //[4, 0, 3, 0]]
    //Eligible integers which will be participated to calculate the sum -
    //matrix = [[X, 2, 3, 2],
    //[X, 6, X, 1],
    //[X, X, X, X]]
    //Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
    class Program
    {
        static int getSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0) && arr[j, i] > 0; j++)
                {
                    sum = sum + arr[j, i];
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {0, 2, 3, 2 },
                {0, 6, 0, 1},
                {4, 0, 3, 0}
            };

            int[,] arr2 =
            {
                {1, 2, 1, 0 },
                {0, 5, 0, 0},
                {1, 1, 3, 10 }
            };
            getSum(arr);

            //getSum(arr2);
        }
    }
}
