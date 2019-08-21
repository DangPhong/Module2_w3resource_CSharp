using System;

namespace BooksManagementSystem
{
    class Program
    {
        public static Book book = new Book();
        public static int id = 0;
        public static void DrawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Insert new book");
                Console.WriteLine("2. View list book");
                Console.WriteLine("3. Average Price");
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
                        Console.WriteLine("insert book");
                        id++;
                        createBook();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("view list of books");
                        book.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("average price");
                        book.Calculate();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            DrawMenu();
        }
        static void Main(string[] args)
        {
            DrawMenu();

        }

        static void createBook()
        {
            Console.WriteLine("---- insert new book----");
            book.Id = id;
            Console.Write("input name: ");
            book.Name = Console.ReadLine();
            Console.Write("input publishdate: ");
            book.PublishDate = Console.ReadLine();
            Console.Write("input author: ");
            book.Author = Console.ReadLine();
            Console.Write("input language: ");
            book.Language = Console.ReadLine();
            Console.WriteLine("input price");

            for (int i = 0; i < book.PriceList.Length; i++)
            {
                Console.Write("input price {0}: ", i + 1);
                book.PriceList[i] = int.Parse(Console.ReadLine());
            }
            book.Insert();
        }


    }
}
