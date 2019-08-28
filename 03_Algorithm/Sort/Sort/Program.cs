using System;

namespace Sort
{
    #region Các thuật toán sắp xếp
    /*
    + Selection Sort 
    + Insert Sort 
    + Bubble Sort 
    + Quick Sort
    */
    #endregion
    class Program
    {
        #region Thuật toán tráo đổi
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Sắp xếp chọn
        public static void SelectSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                var min = arr[i];
                var pos = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        pos = j;
                    }
                }
                Swap(ref arr[i], ref arr[pos]);
            }
            Console.WriteLine(string.Join(",", arr));
        }
        #endregion

        #region Sắp xếp chèn (Insert Sort)
        // khi mỗi phần tử được chèn vào mảng thì phải đảm bảo sắp xếp theo vị trí tăng dần
        public static void InsertSort(int[] arr)
        {
            int length = arr.Length;
            //for (int i = 0; i < length - 1; i++)
            //{
            //    for (int j = i + 1; j < length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            Swap(ref arr[i], ref arr[j]);
            //        }
            //    }
            //}
            int j, temp;
            for (int i = 1; i < length; i++)
            {
                j = i - 1;
                temp = arr[i];
                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine(String.Join(",", arr));
        }
        #endregion

        #region Sắp xếp nổi bọt (Bubble Sort)
        public static void BubbleSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
            Console.WriteLine(string.Join(",", arr));
        }
        #endregion


        #region Sắp xếp nhanh (Quick Sort)
        //https://nguyenvanhieu.vn/thuat-toan-sap-xep-quick-sort/
        public static void QuickSort(int[] arr)
        {
            int length = arr.Length;
            // pivot là phần tử đánh dấu
            int pivot = arr[length - 1];
            int left = arr[0];
            int right = arr[length - 2];
        }

        public static void Partititon(int[] arr)
        {

        }
        #endregion

        static void Main(string[] args)
        {
            int[] array = { 5, 6, 3, 2, 1, 9, 8, 5, 6, 7, 1 };
            Console.WriteLine("trc khi sx");
            Console.WriteLine(string.Join(",", array));

            Console.WriteLine("sau khi sx");
            //  SelectSort(array);
            InsertSort(array);
            // BubbleSort(array);

        }
    }
}

