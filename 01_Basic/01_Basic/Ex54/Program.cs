using System;

namespace Ex54
{
    // Write a C# program to get the century from a year. 

    // Dựa vào thực tế một thế kỷ là 100 năm, vì vậy chúng ta lấy năm chia cho 100
    // Nếu chia hết thì thế kỷ chính là số thương của phép chia
    // Nếu không chia hết thì thế kỷ chính là số thương cộng thêm 1
    class Program
    {

        static int getTheCentury(int year)

        {
            int century;
            if (year % 100 == 0)
            {
                century = year / 100;
            }
            else
            {
                century = year / 100 + 1;
            }
            Console.WriteLine(century);
            return century;
        }


        static void Main(string[] args)
        {
            getTheCentury(1999);
            getTheCentury(510);
            getTheCentury(2018);
        }
    }
}
