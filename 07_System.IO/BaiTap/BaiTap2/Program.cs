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

        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader(inputFile))
            {
                int[,] newArr = new int[n, n];

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

                            if (isPrime(int.Parse(arrNum[i])))
                            {
                                sw.Write(arrNum[i] + " ");
                            }
                        }
                    }
                }
            }
        }

        public static void GetSumMainCross(int[,] arr)
        {

        }

        public static void GetSumSecondCross()
        {
            int sum = 0;
            var m = arr.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                sum += arr[i, m - 1 - i];
            }
            Console.WriteLine(sum);
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
            ReadFile();

           // GetSumSecondCross();
          //  Console.WriteLine(isPrime(4));
        }
    }
}
