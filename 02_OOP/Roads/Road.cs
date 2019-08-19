using System;
using System.Collections.Generic;
using System.Text;

namespace Roads
{

    class Road
    {
        private string number;
        private double turnover;
        private string id;
        private string name;
        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string Number { get => number; set => number = value; }
        public double Turnover { get => turnover; set => turnover = value; }
        public Road()
        {
            this.Id = "";
            this.Name = "";
            this.Number = "";
            this.Turnover = 0;
        }
        public Road(string number, double turnover, string id, string name)
        {
            this.number = number;
            this.turnover = turnover;
            this.id = id;
            this.name = name;
        }
        public virtual void input()
        {
            Console.WriteLine("Nhap ma so chuyen: ");
            Id = Console.ReadLine();
            Console.WriteLine("Ho ten tai xe: ");
            Name = Console.ReadLine();
            Console.WriteLine("So xe: ");
            Number = Console.ReadLine();
            Console.WriteLine("Doanh thu: ");
            Turnover = int.Parse(Console.ReadLine());
        }
        public virtual string toString()
        {
            return "\n Ma so chuyen: " + Id + "\n Ten tai xe: " + Name +
                "\n So xe: " + Number + "\n ";
        }
    }
}
