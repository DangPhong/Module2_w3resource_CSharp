using System;
using System.Collections.Generic;
using System.Text;

namespace BT911_MoviesManagementSystem
{
    class Movie : IMovie
    {
        private string name, director, subtitle;
        private int id;
        private double averageRate;
        private DateTime publishDate;

        public string Name { get => name; set => name = value; }
        public string Director { get => director; set => director = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
        public int Id { get => id; set => id = value; }
        public double AverageRate { get => averageRate; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }

        public string Display()
        {
            return $"ID: {Id} \t\t Name: {Name} \t\t Director: {Director}" +
                $" \t\t Subtitle: {Subtitle} \t\t PublishDate: {PublishDate} \t\t AverageRate: {AverageRate}";
        }

        public double[] RateList = new double[3];

        public double Calculate()
        {
            double sum = 0;
            int length = RateList.Length;
            for (int i = 0; i < length; i++)
            {
                sum += RateList[i];
            }
            averageRate = sum / length;
            return averageRate;
        }
    }
}
