using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalMove_Drink
{
    class Cat : Animal, ICanMove, ICanEat, ICanDrink
    {

        public string CanDrink()
        {
            return "cat can drink";
        }

        public string CanEat()
        {
            return "cat can eat";
        }

        public override string canMove()
        {
            return "cat move ...";
        }
    }
}
