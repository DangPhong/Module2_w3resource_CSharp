using System;
using System.Collections.Generic;
using System.Text;

namespace Roads
{
    // Noi thanh
    class Urban : Road
    {
        // so chuyen, km 
        private string roadNumber;
        private double km;

        public string RoadNumber { get => roadNumber; set => roadNumber = value; }
        public double Km { get => km; set => km = value; }

        public Urban() :base()
        {
            this.RoadNumber = "";
            this.Km = 0;
        }

        public Urban(string id, string name, string number, double turnover, string roadNumber, double km)
            : base(number, turnover, id, name)
        {
            this.roadNumber = roadNumber;
            this.km = km;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap so tuyen: ");
            RoadNumber = Console.ReadLine();
            Console.WriteLine("Nhap km: ");
            Km = double.Parse(Console.ReadLine());
        }

        public override string toString()
        {
            return "Chuyen xe noi thanh" + base.toString() + "\n so tuyen: " + RoadNumber
                + "\n so km: " + Km + "\n Doanh thu: " + Turnover;
        }
    }
}
