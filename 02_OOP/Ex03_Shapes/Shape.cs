using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03_Shapes
{
    class Shape
    {
        protected Location c;

        public string toString()
        {
            return "";
        }

        public double Area()
        {
            return c.X + c.Y;
        }

        public double Perimeter()
        {
            return c.X + c.Y;
        }
    }
}