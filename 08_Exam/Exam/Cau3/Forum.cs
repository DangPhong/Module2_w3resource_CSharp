using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Cau3
{
    class Forum
    {
        public static int id = 0;
        public static List<Post> PostList = new List<Post>();
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Creat post");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Show list");
                Console.WriteLine("4. Exit");

                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 4);
            Process(option);
        }

        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Creat post");
                        CreatePost();

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Calculator");
                        Calculator();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Show list");
                        ShowList();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void CreatePost()
        {
            Post post = new Post();
            post.Id = id++;
            Console.Write("input title: ");
            post.Title = Console.ReadLine();
            Console.Write("input content: ");
            post.Content = Console.ReadLine();
            Console.Write("input author: ");
            post.Author = Console.ReadLine();
            Console.Write("input rate: ");
            for (int i = 0; i < post.Rates.Length; i++)
            {
                Console.Write("input rate {0}: ", i+1);
                post.Rates[i] = int.Parse(Console.ReadLine());
            }
            PostList.Add(post);

        }

        public static void Calculator()
        {
            foreach (Post post in PostList)
            {
                post.CalculatorRate();
            }
        }

        public static void ShowList()
        {
            foreach (Post post in PostList)
            {
                Console.WriteLine(post.Display());  
            }
        }
        static void Main(string[] args)
        {
            InitMenu();
        }
    }
}
