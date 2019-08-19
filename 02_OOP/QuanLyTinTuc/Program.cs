using System;
using System.Collections.Generic;


namespace QuanLyTinTuc
{
    class Program
    {
        public static int option = 0;

        public static News newService = new News();
        News newsSevice = new News();
        
        public static void drawMenu()
        {
            do
            {
                Console.WriteLine("1. insert news ");
                Console.WriteLine("2. view list news  ");
                Console.WriteLine("3. average rate ");
                Console.WriteLine("4. exit ");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());
            } while (option < 0 || option > 4);
        }

        public static void Proccess(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        InsertNews();
                        break;
                    }

                case 2:
                    {
                        ViewListNew();
                        break;
                    }
                case 3:
                    {
                        AverageRate();
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

        public static void InsertNews()
        {
            Console.WriteLine("-----insert news----- ");

            Console.Write("input title: ");
            var title = Console.ReadLine();
            newService.Title = title;
            Console.Write("input publicDate: ");
            var publicDate = Console.ReadLine();
            newService.PublicDate = publicDate;
            Console.Write("input author: ");
            var author = Console.ReadLine();
            newService.Author = author;
            Console.Write("input content: ");
            var content = Console.ReadLine();
            newService.Content = content;
        }

        public static void ViewListNew()
        {
            Console.WriteLine("------view listnews----- ");
            newService.Display();
        }

        public static void AverageRate()
        {
            Console.WriteLine("-----average rate----- ");
            for (int i = 0; i < newService.RateList.Length; i++)
            {
                Console.Write("input rate {0}: ", i + 1);
                newService.RateList[i] = int.Parse(Console.ReadLine());
            }
            newService.Caculate();
        }
        static void Main(string[] args)
        {
            drawMenu();
            do
            {
                Proccess(option);
            } while (option != 4);
        }
    }
}