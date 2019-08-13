using System;
using System.Collections.Generic;
using System.Text;

namespace Roads
{
    // Ngoai thanh
    class Suburbs : Road
    {
        // diem den , so ngay
        private string destination;
        private int day;

        public string Destination { get => destination; set => destination = value; }
        public int Day { get => day; set => day = value; }

        public Suburbs(): base()
        {
            this.Day = 0;
            this.Destination = "";
        }

        public Suburbs(string id, string name, string number, double turnover, string destination, int day)
            : base(number, turnover, id, name)
        {
            this.destination = "";
            this.day = 0;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Noi den: ");
            Destination = Console.ReadLine();
            Console.WriteLine("So ngay:");
            Day = int.Parse(Console.ReadLine());
        }

        public override string toString()
        {
            return "Chuyen xe ngoai thanh:" + base.toString()
                + " noi den: " + Destination + " So ngay: " + Day + "\n Doanh thu: " + Turnover;
        }
    }
}
