using System;

namespace Ex40
{
    class Program
    {
        static int checkTheNearestValueOf20(int a, int b)
        {

            if (Math.Abs(a - 20) > Math.Abs(b - 20))
            {
                return b;
            }
            else if (Math.Abs(a - 20) < Math.Abs(b - 20))
            {
                return a;
            }

            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(checkTheNearestValueOf20(9, 19));
            Console.WriteLine(checkTheNearestValueOf20(9, -19));
            Console.WriteLine(checkTheNearestValueOf20(19, 19));
        }
    }
}
