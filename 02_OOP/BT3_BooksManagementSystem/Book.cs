using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BooksManagementSystem.Models;
namespace BooksManagementSystem
{
    class Book : IBook
    {
        private int id;
        private string name, publishDate, author, language;
        private float averagePrice;
        private float[] priceList = new float[5];
        List<BooksItem> booksItems = new List<BooksItem>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }
        public float AveragePrice { get => averagePrice; }
        public float[] PriceList { get => priceList; set => priceList = value; }

        public void Display()
        {
            foreach (var item in booksItems)
            {
                Console.WriteLine("Ten sach: " + item.Name);
                Console.WriteLine("Ngay xuat ban: " + item.PublishDate);
                Console.WriteLine("Tac gia: " + item.Author);
                Console.WriteLine("Ngon ngu: " + item.Language);
                Console.WriteLine("Gia trung binh: " + item.AveragePrice);
                Console.WriteLine("-------------------------------------------");
            }
        }

        public void Calculate()
        {
            int length = PriceList.Length;
            float total = 0;
            for (int i = 0; i < length; i++)
            {
                total += PriceList[i];
            }
            averagePrice = total / length;
            Console.WriteLine("Gia trung binh: {0}", averagePrice);
        }

        public void Insert()
        {
            Calculate();
            BooksItem booksItemss = new BooksItem()
            {
                Id = Id,
                Name = Name,
                PublishDate = PublishDate,
                Author = Author,
                Language = Language,
                AveragePrice = AveragePrice
            };
            booksItems.Add(booksItemss);
        }
    }
}
