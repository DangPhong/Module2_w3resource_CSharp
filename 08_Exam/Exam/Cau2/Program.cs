 using System;

namespace Cau2
{
    class Program
    {
        public static int n;
        public static int[] arr = new int[n];
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Tao mang");
                Console.WriteLine("2. Kiem tra mang tang");
                Console.WriteLine("3. Sap xep mang tang");
                Console.WriteLine("4. Tim kiem mang");
                Console.WriteLine("5. Thoat");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 5);
            Process(option);
        }

        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Tao mang");
                        Console.WriteLine("Nhap do dai n: ");
                        n = int.Parse(Console.ReadLine());
                        arr = new int[n];
                        InitArray(arr, n);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Kiem tra mang tang");
                        Console.WriteLine(IsIncreaseArray(arr));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Sap xep mang tang");
                        SelectedSort(arr);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tim kiem mang");
                        Console.WriteLine("Nhap gia tri can tim: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine(Find(arr, num));
                        break;
                    }
                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void InitArray(int[] arr, int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("mang da nhap:");
            Console.WriteLine(string.Join(" ", arr));
        }

        public static void SelectedSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("mang da sap xep tang dan:");
            Console.WriteLine(string.Join(" ", arr));
        }

        public static string Find(int[] arr, int num)
        {
            //Console.WriteLine("nhap gia tri can tim: ");
            //num = int.Parse(Console.ReadLine());
            int first = 0;
            int last = arr.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (arr[mid] == num)
                {
                    return $"tim thay {num} tai vi tri {mid}";

                }
                else if (num < arr[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return $"khong tim thay {num}";
        }

        public static bool IsIncreaseArray(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        return false;
                    } 
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            InitMenu();
           
           // InitArray(arr, n);
        }

    }
}
