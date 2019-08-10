using System;

namespace Ex56
{
    class Program
    {
        static bool isPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string a = "111121111";
            string b = "1111211";
            Console.WriteLine(isPalindrome(a));
            Console.WriteLine(isPalindrome(b));
            Console.WriteLine("Hello World!");
        }
    }
}
