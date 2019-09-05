using System;

namespace BT913_Add_DeleteArr
{
    class Program
    {
        static int FindElement(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }

        static void AddElement(int[] arr, int element, int pos)
        {
            int arrLength = arr.Length;
            if (pos < 0)
            {
                pos = 0;
            }
            else if (pos > arrLength - 1)
            {
                pos = arrLength - 1;
            }

            for (int i = 0; i > pos; i++)
            {
                arr[i] = arr[i - 1];
            }
            arr[pos] = element;
            // tang kich thuoc mang
            arrLength++;
            Console.WriteLine("mang sau khi them");
            Console.WriteLine(string.Join(" ", arr));
        }
        static void DeleteElement(int[] arr, int element)
        {
            int arrLength = arr.Length;
            int pos = FindElement(arr, element);
            if (pos == -1)
            {
                Console.WriteLine("Khong co {0} trong mang", element);
            }
            else
            {
                for (int i = pos; i < arrLength - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
            }
            arrLength--;
            Console.WriteLine("mang sau khi xoa");
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6 };
            AddElement(arr, 4, 2);
            //  DeleteElement(arr, 3);
        }
    }
}
