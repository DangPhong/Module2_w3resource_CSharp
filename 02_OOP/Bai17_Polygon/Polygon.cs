using System;

namespace Bai17_Polygon
{
    public class Polygon
    {
        private int side;
        private float[] arrSide;

        public int Side
        {
            get => side;
            set => side = value;
        }

        public float[] ArrSide
        {
            get => arrSide;
            set => arrSide = value;
        }


        public Polygon()
        {
        }

        public Polygon(int side)
        {
            Side = side;
            ArrSide = new float[Side];
        }

        public virtual float GetPerimeter()
        {
            float perimeter = 0;
            for (int i = 0; i < Side; i++)
            {
                perimeter = perimeter + arrSide[i];
            }

            return perimeter;
        }

        public void Display()
        {
            for (int i = 0; i < Side; i++)
            {
                Console.WriteLine("Canh thu " + i + 1 + ":" + arrSide[i]);
            }
        }
    }
}