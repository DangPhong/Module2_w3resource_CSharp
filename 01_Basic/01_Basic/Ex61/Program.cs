using System;

namespace Ex61
{
    //  Write a C# program to sort the integers in ascending order without moving the number -5
    public class Program
    {
        public  void Main(string[] args)
        {
            int[] arr1 = { -5, 236, 120, 70, -5, -5, 698, 280 };
            sortAscending(arr1,-5);

        }
        public void sortAscending(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    continue;
                }
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] == num)
                    {
                        continue;
                    }
                    else if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
