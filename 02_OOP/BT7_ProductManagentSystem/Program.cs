using System;

namespace BT7_ProductManagentSystem
{
    class Program
    {
        public static Shop shop = new Shop();
        public static void DrawMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("-----PRODUCT MANAGEMENT SYSTEM-----");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Remove produre");
                Console.WriteLine("3. Iterate product list");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit");
                Console.Write("option:");

                // option = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 5);
            Process(option);
        }
        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Add new product...");
                        shop.AddProduct();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove produre...");
                        shop.RemoveProduct();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Iterate product list...");
                        shop.Display();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search product...");
                        shop.SearchProduct();
                        break;
                    }
                case 5:
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
    }
}
