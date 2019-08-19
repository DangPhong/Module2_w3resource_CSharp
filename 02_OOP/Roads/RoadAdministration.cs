using System;
using System.Collections.Generic;
using System.Text;

namespace Roads
{
    class RoadAdministration
    {
        static void Main(string[] args)
        {
            int choice = -1;
            ListRoads dscx = new ListRoads();
            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Them chuyen xe noi thanh");
                Console.WriteLine("2. Them chuyen xe ngoai thanh");
                Console.WriteLine("3. Hien thi danh muc chuyen xe");
                Console.WriteLine("-----------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        dscx.listRoad(1);
                        break;
                    case 2:
                        dscx.listRoad(2);
                        break;
                    case 3:
                        dscx.output();
                        break;
                }
            } while (choice != 0);

            Console.WriteLine();
        }
    }
}