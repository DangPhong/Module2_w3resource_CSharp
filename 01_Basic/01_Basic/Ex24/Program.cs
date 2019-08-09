using System;

namespace Ex24
{
    class Program
    {
        //24. Write a C# program to find the longest word in a string.
        static void Main(string[] args)
        {
            string str = "  nguyen     dang      phong dangffffff       ";
            //string[] arr = str.Split(' ');
            //string maxStr = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i].Length > maxStr.Length)
            //    {
            //        maxStr = arr[i];
            //    }
            //}
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i]==' ' && str[i+1] != ' ')
                {
                    str = str.Remove(i, 1);
                }
            }

            Console.WriteLine(str);
            //Console.WriteLine(string.Join(",",arr));
            //Console.WriteLine("the longest word in a string is: "+ maxStr);
        }
    }
}
