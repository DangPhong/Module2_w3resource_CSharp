using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalMove_Drink
{
    class Animal : ICanMove
    {
        public virtual string canMove()
        {
            return "Animal move...";
        }
    }
}
