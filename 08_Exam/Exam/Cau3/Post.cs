using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3
{
    class Post : IPost
    {
        private int id;
        private string title, content, author;
        private float averageRate;
        private int[] rates = new int[4];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public float AverageRate { get => averageRate; }
        public int[] Rates { get => rates; set => rates = value; }

        public float CalculatorRate()
        {
            int length = Rates.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += Rates[i];
            }
            averageRate = (float)sum / length;
            return averageRate;
        }

        public string Display()
        {
            return $"Id: {Id} \t\t Title: {Title} \t\t Content: {Content} \t\t Author: {Author} \t\t AverageRate: {AverageRate}";
        }
    }
}
