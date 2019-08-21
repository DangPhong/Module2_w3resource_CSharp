using QuanLyTinTuc.Models;
using System;
using System.Collections;
using System.Collections.Generic;


namespace QuanLyTinTuc
{
    class Program
    {
        public static News news = new News();
        public static int Id = 0;
        public static void drawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. insert news ");
                Console.WriteLine("2. view list news  ");
                Console.WriteLine("3. average rate ");
                Console.WriteLine("4. exit ");
                Console.WriteLine("Please select an option");
                Console.Write("Option: ");
                // option = int.Parse(Console.ReadLine());

                // nhập vào chuyển về kiểu int
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 4);
            Proccess(option);
        }
        public static void Proccess(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("insert news");
                        Id++;
                        createNews();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news ....");
                        news.Display();
                        break;
                    }
                case 3:
                    {
                        // AverageRate();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            drawMenu();
        }
        public static void createNews()
        {
            Console.WriteLine("-----insert news----- ");
            news.Id = Id;
            Console.Write("input title: ");
            news.Title = Console.ReadLine();
            Console.Write("input publicDate: ");
            news.PublishDate = Console.ReadLine();
            Console.Write("input author: ");
            news.Author = Console.ReadLine();
            Console.Write("input content: ");
            news.Content = Console.ReadLine();
            Console.WriteLine("input rates");
            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.Write("input rate {0}: ", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }
            news.InsertNews(Id);
        }

       
        //public static void ViewListNew()
        //{
        //    Console.WriteLine("------view listnews----- ");
        //    newService.Display();
        //}

        //public static void AverageRate()
        //{
        //    Console.WriteLine("-----average rate----- ");
        //    for (int i = 0; i < newService.RateList.Length; i++)
        //    {
        //        Console.Write("input rate {0}: ", i + 1);
        //        newService.RateList[i] = int.Parse(Console.ReadLine());
        //    }
        //    newService.Caculate();
        //}
        static void Main(string[] args)
        {
            drawMenu();
        }
    }
}