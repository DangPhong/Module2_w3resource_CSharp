using System;

namespace Ex62_SapXepDuongAm0
{
    // Sắp xếp mảng theo thứ tự số dương tăng dần, số âm giảm
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void sort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                
                for (int j = i + 1; j < length; j++)
                {

                    // sx duong qua ben trai , am qua ben phai
                    if (arr[i] < 0 && arr[j] > 0)
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[j];
                        //arr[j] = temp;
                        swap(ref arr[i], ref arr[j]);
                    }
                    //sx so duong giam dan
                    if (arr[j] >= 0 && arr[i] > arr[j])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[j];
                        //arr[j] = temp;
                        swap(ref arr[i], ref arr[j]);
                    }

                    //sx so am tang dan
                    if (arr[j] < 0 && arr[i] < arr[j])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[j];
                        //arr[j] = temp;
                        swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
        static void Main(string[] args)
        {
            int[] arr = { 89, 25, 36, 0, -2, 6, -33, 44, 33, -99 };
            sort(arr);
        }
    }
}
