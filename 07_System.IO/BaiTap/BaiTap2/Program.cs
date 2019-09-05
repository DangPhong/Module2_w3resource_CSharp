using System;
using System.IO;
namespace BaiTap2
{
    class Program
    {
        public static string inputFile = "C:\\Module2_w3resource_CSharp\\07_System.IO\\BaiTap\\BaiTap2\\ArrInput.txt";
        public static string outputFile = "C:\\Module2_w3resource_CSharp\\07_System.IO\\BaiTap\\BaiTap2\\ArrOutput.txt";
        public static int n;
        public static int[,] arr;

        public static void WriterFile()
        {
            using (StreamWriter sw = new StreamWriter(inputFile))
            {
                sw.WriteLine(n);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sw.Write(arr[i, j] + " ");
                    }
                    sw.WriteLine();
                }
            }
        }

        public static void WriterFileOut(string s)
        {
            using (StreamWriter sw = new StreamWriter(outputFile, true))
            {
                sw.WriteLine(s);
            }
        }


        public static int[,] ReadFile()
        {
            int[,] newArr = new int[n, n];
            using (StreamReader sr = new StreamReader(inputFile))
            {
                // bỏ qua hàng đầu
                int index = 0;
                string line;
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (index == 0)
                        {
                            index++;
                            continue;
                        }

                        var arrNum = line.Trim().Split(" ");
                        for (int i = 0; i < arrNum.Length; i++)
                        {
                            newArr[index - 1, i] = Convert.ToInt32(arrNum[i]);
                        }
                        index++;
                    }
                }
            }
            return newArr;
        }

        //Doc mang
        public static void ReadArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // tinh duong cheo chinh
        public static int GetSumMainCross(int[,] arr)
        {
            int sum = 0;
            var m = arr.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine(sum);
            return sum;
        }

        //tinh duong cheo phu
        public static int GetSumSecondCross(int[,] arr)
        {
            int sum = 0;
            var m = arr.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                sum += arr[i, m - 1 - i];
            }
            Console.WriteLine(sum);
            return sum;
        }

        // dem cac so nguyen to
        public static int CountPrime(int[,] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (isPrime(arr[i,j]))
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        // dem cac so chan 
        public static int CountEven(int[,] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]% 2 ==0)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }
        static void inputArr()
        {
            Console.Write("input n: ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("arr[{0}][{1}]= ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // kiem tra so nguyen to
        static bool isPrime(int num)
        {
            bool check = true;
            if (num < 2)
            {
                check = false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            inputArr();
            WriterFile();
            int[,] arrq = ReadFile();
            ReadArr(arrq);
            
            WriterFileOut("Tong duong cheo chinh: " + GetSumMainCross(arrq));
            WriterFileOut("Tong duong cheo phu: " + GetSumSecondCross(arrq));
            WriterFileOut("Có "+ CountEven(arrq) +" so chan.");
            WriterFileOut("Có " + CountPrime(arrq) + " so nguyen to.");
        }
    }
}
