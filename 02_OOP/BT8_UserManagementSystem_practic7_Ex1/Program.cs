using System;
using System.Collections.Generic;
namespace BT8_UserManagementSystem_practic7_Ex1
{
    class Program
    {
        static int id = 0;

        Dictionary<int, User> UserList = new Dictionary<int, User>();
        #region đề 
        //https://v1study.com/csharp-practical-7-a654.html
        #endregion
        public static void DrawMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("-----USER MANAGEMENT SYSTEM-----");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Check User");
                Console.WriteLine("3. Display all Users");

                Console.Write("option:");

                // option = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out int number))
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
                        Console.WriteLine("Add user...");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check User...");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display all Users...");
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

        public void AddUser()
        {
            id++;
            Console.Write("input name: ");
            string name = Console.ReadLine();
            Console.Write("input password: ");
            string password = Console.ReadLine();
            Console.WriteLine("input phone: ");
            Console.WriteLine("how many phone number?");
            int number = int.Parse(Console.ReadLine());
            List<int> phoneList = new List<int>(number);


            int phone;
            for (int i = 0; i < number; i++)
            {
                Console.Write("input phone number {0}:", i + 1);
                phoneList[i] = int.Parse(Console.ReadLine());
            }
            User user = new User()
            {
                Name = name,
                Password = password,
                PhoneList = phoneList
            }


        }
        static void Main(string[] args)
        {
            DrawMenu();
        }
    }
}
