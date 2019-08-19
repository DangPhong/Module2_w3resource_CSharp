using System;

namespace Bai17_Polygon
{
    public class Triangle : Polygon
    {
        public Triangle()
        {
        }

        public Triangle(int side) : base(side)
        {
        }

        Polygon triangle = new Polygon(3);

        public override float GetPerimeter()
        {
            float perimeter = 0;
            for (int i = 0; i < triangle.Side; i++)
            {
                perimeter = perimeter + triangle.ArrSide[i];
            }

            return perimeter;
        }

        public double getArea()
        {
            double area;
            float p = (triangle.ArrSide[0] + triangle.ArrSide[1] + triangle.ArrSide[2]) / 2;
            area = Math.Sqrt(p * (p - ArrSide[0]) * (p - ArrSide[1] * (p - ArrSide[2])));
            return area;
        }
    }
}