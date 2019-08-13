using System;
using System.Collections.Generic;
using System.Text;

namespace Roads
{
    // danh sach chuyen xe
    class ListRoads
    {
        private Road[] road = new Road[100];
        private int countRoad;
        private double sum1, sum2;

        public void listRoad(int temp)
        {
            if (countRoad > 100)
            {
                Console.WriteLine(" ko the them du lieu!");
            }
            else
            {
                if (temp == 1)
                {
                    road[countRoad] = new Urban();
                    Urban noiThanh = new Urban();
                    noiThanh.input();
                    road[countRoad] = noiThanh;
                    sum1 += noiThanh.Turnover;
                }
                else
                {
                    road[countRoad] = new Suburbs();
                    Suburbs ngoaiThanh = new Suburbs();
                    ngoaiThanh.input();
                    road[countRoad] = ngoaiThanh;
                    sum2 += ngoaiThanh.Turnover;
                }
                countRoad++;
            }
        }
        public void output()
        {
            for (int i = 0; i < countRoad; i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(road[i].toString());
            }
            Console.WriteLine("---------------Doanh thu ----------------");
            Console.WriteLine("Chuyen xe noi thanh " + sum1);
            Console.WriteLine("Chuyen xe ngoai thanh " + sum2);
            Console.WriteLine("------------------------------------------");

        }
    }
}
