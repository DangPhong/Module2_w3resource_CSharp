using System;

namespace BT911_MoviesManagementSystem
{
    class Program
    {
        public static void Swap(ref int a , ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        static void Main(string[] args)
        {
            int a = 6;
            int b = 9;
            Swap(ref a, ref b);
        }
    }
}
