using System;
using System.Collections.Generic;
using System.Text;

namespace BT7_ProductManagentSystem
{
    public class Product
    {
        private string name, description;
        private double price;
        private int[] rate = new int[5];
        private float average;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price
        {
            get => price; set => price = value;

        }
        //  public int[] Rate { get => rate; set => rate = value; }
        public float Average { get => average; set => average = value; }
        public int[] Rate { get => rate; set => rate = value; }

        public float CalAveragePoint()
        {
            int length = Rate.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += Rate[i];
            }
            Average = (float)(sum / length);
            return Average;
        }
        public void ViewInfo()
        {
            Console.WriteLine("Name: {0} \t Price: {1} \t Description: {2} \t Average point: {3}"
                , Name, Price, Description, CalAveragePoint());
        }
    }
}
