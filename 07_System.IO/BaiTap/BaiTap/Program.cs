using System;
using System.IO;
using System.Collections;
namespace BaiTap
{
    class Program
    {
        public static string intputFile = "D:\\Module2_Clone\\Module2_w3resource_CSharp\\07_System.IO\\BaiTap\\Input.txt";
        public static string outputFile = "D:\\Module2_Clone\\Module2_w3resource_CSharp\\07_System.IO\\BaiTap\\Output.txt";

        public static void InputElement()
        {
            FileStream file = new FileStream(intputFile, FileMode.Create);
            Console.Write("input size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("input element {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(n);
                writer.WriteLine(string.Join(" ", arr));
            }
            file.Close();
        }

        public static void GetSum()
        {
            //FileStream file1 = new FileStream(filePath, File.OpenText(file1));
            using (StreamReader sr = new StreamReader(intputFile))
            {
                string line;
                int index = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    var arrayNum = line.Split(" ");
                    int sum = 0;
                    ArrayList arrayEven = new ArrayList();
                    for (int i = 0; i < arrayNum.Length; i++)
                    {
                        sum += int.Parse(arrayNum[i]);
                    }
                    Console.WriteLine(line);
                    Console.WriteLine(string.Join(" ", arrayNum));
                    Console.Write("tong gia tri: {0}", sum);

                    using (StreamWriter sw = new StreamWriter(outputFile))
                    {
                        sw.WriteLine("tong gia tri: {0}", sum);
                        sw.Write("cac so chan: ");
                        for (int i = 0; i < arrayNum.Length; i++)
                        {
                            if (int.Parse(arrayNum[i]) % 2 == 0)
                            {
                                sw.Write(arrayNum[i] + " ");
                            }
                        }

                        sw.Write("sap xep mang tang dan: ");
                        for (int i = 0; i < arrayNum.Length - 1; i++)
                        {
                            for (int j = i + 1; j < arrayNum.Length; j++)
                            {
                                int a = int.Parse(arrayNum[i]);
                                int b = int.Parse(arrayNum[j]);
                                if (a > b)
                                {
                                    Swap(ref a, ref b);
                                }
                            }
                        }
                        for (int i = 0; i < arrayNum.Length; i++)
                        {
                            Console.Write(arrayNum[i] +" " );
                        }

                    }
                }
            }



        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void GetEvenNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static void SortArr(int[] arr)
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
        }
        static void Main(string[] args)
        {
            InputElement();
            GetSum();
        }
    }
}
