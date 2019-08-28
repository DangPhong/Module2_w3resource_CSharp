using System;

namespace BT910_ZooManagementSystem_Practic2_Ex2
{
    class Program
    {
        public static void DrawMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("-----ZOO MANAGEMENT SYSTEM-----");
                Console.WriteLine("1. Add cage");
                Console.WriteLine("2. Remove cage");
                Console.WriteLine("3. Add Animal");
                Console.WriteLine("4. Remove Animal");
                Console.WriteLine("5. Iterate Animals");
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
                        Console.WriteLine("Add cage...");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove cage...");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Add Animal...");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Remove Animal...");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Iterate Animals...");
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
            Console.WriteLine("Hello World!");
        }
    }
}
