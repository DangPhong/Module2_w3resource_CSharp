using System;

namespace BT6_FootballManagementSystem
{
    class Program
    {
        public static void DrawMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("-----Football Management System-----");
                Console.WriteLine("1. create new player");
                Console.WriteLine("2. list all players");
                Console.WriteLine("3. search player by name");
                Console.WriteLine("4. raise attack event");
                Console.WriteLine("5. raise defense event");
                Console.WriteLine("6. Exit");
                Console.Write("option:");

                // option = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 6);
            Process(option);
        }
        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("create new player...");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("list all players...");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("search player by name...");
                        Console.Write("input name to search: ");

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("raise attack event...");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("raise defense event...");
                        break;
                    }
                case 6:
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
