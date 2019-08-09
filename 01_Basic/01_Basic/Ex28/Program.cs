using System;

namespace Ex28
{
    //28. Write a C# program to reverse the words of a sentence.
    class Program
    {
        static void reverse(string str)
        {
            string newString = "";
            int length = str.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                newString = newString + str[i];
            }
            Console.WriteLine(newString);
        }
        static void Main(string[] args)
        {
            Console.Write("enter a string: ");
            string str = Console.ReadLine();
            reverse(str);
        }
    }
}
