using System;
using System.Collections.Generic;
using System.Text;

namespace BT6_FootballManagementSystem
{
    //https://v1study.com/csharp-practical-6-a628.html
    interface IPlayer
    {
        string Name { get; set; }
        int Age { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Stamina { get; set; }
        int Speed { get; set; }
        int Power { get; set; }
        void GetInfo();
    }
}