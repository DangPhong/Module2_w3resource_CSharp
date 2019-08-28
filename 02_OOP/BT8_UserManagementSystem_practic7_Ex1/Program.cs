using System;
using System.Collections.Generic;
namespace BT8_UserManagementSystem_practic7_Ex1
{
    class Program
    {
        public static int id = 0;

        public static Dictionary<int, User> UserList = new Dictionary<int, User>();
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
                Console.WriteLine("4. Exit");
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
                        createUser();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check User...");
                        CheckUser();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display all Users...");
                        Display();
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

        public static void createUser()
        {
            User user = new User();
            id = id + 1;
            user.ID = id;
            Console.Write("input name: ");
            user.Name = Console.ReadLine();
            Console.Write("input password: ");
            user.Password = Console.ReadLine();
            Console.WriteLine("do you want to add phone number? (Y/N) ");
            var phone = Console.ReadLine();
            Console.WriteLine("how many phone number you have?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (string.Compare(phone.ToUpper(), "Y") == 0)
                {
                    Console.Write("Please input phone number: ");
                    user.PhoneList.Add(int.Parse(Console.ReadLine()));
                }
            }
            UserList.Add(user.ID, user);
        }

        public static void CheckUser()
        {
            Console.Write("input user name to want check: ");
            var name = Console.ReadLine();
            Console.Write("input password: ");
            var password = Console.ReadLine();

            var isExit = false;
            foreach (var item in UserList)
            {
                if (item.Value.Name == name && item.Value.Password == password)
                {
                    isExit = true;
                    break;
                }
            }

            if (isExit)
            {
                Console.WriteLine("user is exit");
            }
            else
            {
                Console.WriteLine("user not found");
            }
        }

        public static void Display()
        {
            //foreach (KeyValuePair<int,User> item in UserList)
            //{
            //    Console.WriteLine(item.Value.DisplayInfor());
            //}

            foreach (var item in UserList)
            {
                Console.WriteLine(item.Value.DisplayInfor());
            }
        }
        static void Main(string[] args)
        {
            DrawMenu();
        }
    }
}
