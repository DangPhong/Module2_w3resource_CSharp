using System;
using System.Collections;
using QuanLyTinTuc.Models;
namespace QuanLyTinTuc
{
    public class News : INew
    {
        private int id;
        private string title, publishDate, author, content;
        private float averageRate;
        public NewsItem[] ArrayList = new NewsItem[100];
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AverageRate
        {
            get => averageRate;
            //set => averageRate = value;
        }

        public News()
        {

        }

        public void Display()
        {
            foreach (var newIteam in ArrayList)
            {
                if (newIteam != null)
                {
                    Console.WriteLine("Tieu de: " + newIteam.Title);
                    Console.WriteLine("Ngay xuat ban" + newIteam.PublishDate);
                    Console.WriteLine("Tac gia: " + newIteam.Author);
                    Console.WriteLine("The loai: " + newIteam.Content);
                    Console.WriteLine("Diem trung binh: " + newIteam.AverageRate);
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }

        private int[] rateList = new int[3];

        public int[] RateList
        {
            get => rateList;
            set => rateList = value;
        }

        public void Caculate()
        {
            int length = RateList.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += RateList[i];
            }

            averageRate = sum / length;
            Console.WriteLine("Danh gia trung binh: " + averageRate);
        }

        public void InsertNews(int index)
        {
            Caculate();
            var newsIteam = new NewsItem()
            {
                Id = Id,
                Author = Author,
                Content = Content,
                PublishDate = PublishDate,
                Title = Title,
                AverageRate = AverageRate
            };
            ArrayList[index] = newsIteam;
        }
    }
}