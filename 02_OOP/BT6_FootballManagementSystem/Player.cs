using System;
using System.Collections.Generic;
using System.Text;

namespace BT6_FootballManagementSystem
{
    class Player : IPlayer
    {
        private string name;
        private int age;
        private int attack, defense, stamina, speed, power;
        public string Name { get => name; set => name = value; }
        private int averagePointOfPlayer;
        public int Age
        {
            get => age;
            set
            {
                if (0 < value && 40 > value)
                {
                    age = value;
                }
            }
        }

        public int Attack
        {
            get => attack;
            set
            {
                if (0 < value && 100 > value)
                {
                    attack = value;
                }
            }
        }
        public int Defense
        {
            get => defense; set
            {
                if (0 < value && 100 > value)
                {
                    defense = value;
                }
            }
        }
        public int Stamina
        {
            get => stamina; set
            {
                if (0 < value && 100 > value)
                {
                    stamina = value; 
                }
            }
        }
        public int Speed
        {
            get => speed; set
            {
                if (0 < value && 100 > value)
                {
                    speed = value;
                }
            }
        }
        public int Power
        {
            get => power; set
            {
                if (0 < value && 100 > value)
                {
                    power = value;
                }
            }
        }

        public int AveragePointOfPlayer
        {
            get => averagePointOfPlayer;

            set
            {
                averagePointOfPlayer = (Attack + Defense + Speed + Stamina + Power) / 5;
            }

        }

        public void GetInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Average point of player {2},"
                , Name, Age, AveragePointOfPlayer);
        }

        delegate void ActionDelegate();

    }
}
