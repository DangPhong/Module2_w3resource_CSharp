using System;

namespace Ex15
{
    class Program
    {
        static string removeChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //static string removeChar2(string str, char ch)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ch)
        //        {
        //            str[i] == str[i + 1];
        //        }
        //    }
        //    Console.WriteLine(str);
        //    return str;
        //}

        static void swapFisrtLast(char[] str)
        {
            char temp =  str[0];
            str[0] = str[str.Length - 1];
            str[str.Length - 1] = temp;

            Console.WriteLine(string.Join(",",str));
        }

        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c' };
            swapFisrtLast(arr);
            string str = "phoooong";
           // removeChar2(str, 'o');
            Console.WriteLine(removeChar("CCodeGym", 1));  
        }
    }
}
