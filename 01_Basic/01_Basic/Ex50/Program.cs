using System;

namespace Ex50
{
    // Write a C# program to rotate an array (length 3) of integers in left direction.
    //Go to the editor
    // Test Data:
    //Array1: [1, 2, 8]
    //After rotating array becomes: [2, 8, 1]
    class Program
    {
        static void rotateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 8, 9, 5 };
            Console.WriteLine(string.Join(",", nums));
            rotateArray(nums);
            Console.WriteLine(string.Join(",", nums));
        }
    }
}
