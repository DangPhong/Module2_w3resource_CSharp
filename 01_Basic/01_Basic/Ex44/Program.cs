using System;

namespace Ex44
{
    //Write a C# program to create a new string of every other character (odd position) 
    //from the first position of a given string. 
    class Program
    {
        static void Main(string[] args)
        {
            string str = "nGuYeNdAnGpHoNg";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result = result + str[i];
                }
            }
            Console.WriteLine( result);
        }
    }
}
