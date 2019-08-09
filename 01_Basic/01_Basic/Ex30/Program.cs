using System;

namespace Ex30
{
    class Program
    {
        // Write a C# program to convert a hexadecimal number to decimal number. 
        static void Main(string[] args)
        {
            string hexval = "4B0";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.Write("Convert to-Decimal number: " + decValue);   
        }
    }
}
