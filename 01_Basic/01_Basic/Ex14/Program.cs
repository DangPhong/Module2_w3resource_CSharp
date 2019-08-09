using System;

namespace Ex14
{
    class Program
    {
        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        static void Main(string[] args)
        {
            Console.Write("enter the celcius: ");
            float c = float.Parse(Console.ReadLine());
            float f = c * 1.8f + 32;
            float kelvin = c + 273;
            Console.WriteLine("{0} do C = {1} do F", c, f);
            Console.WriteLine("{0} do C = {1} do kelvin", c, kelvin);
        }
    }
}
