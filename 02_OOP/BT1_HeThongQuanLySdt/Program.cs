using HeThongQuanLySdt.Models;
using System;

namespace HeThongQuanLySdt
{
    class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();

        public static void drawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("---- PHONE BOOKS MANAGEMENT SYSTEM ----");
                Console.WriteLine("1. insert phone ");
                Console.WriteLine("2. remove phone  ");
                Console.WriteLine("3. update phone ");
                Console.WriteLine("4. search phone ");
                Console.WriteLine("5. sort ");
                Console.WriteLine("6. display ");
                Console.WriteLine("7. exit ");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option <= 0 || option > 7);
            Process(option);
        }

        public static void Process(int select)
        {
            Console.Clear();
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("insert phone....");
                        Console.Write("input name: ");
                        string name = Console.ReadLine();
                        Console.Write("input phone: ");
                        string phone = Console.ReadLine();
                        phoneBook.InsertPhone(name, phone);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("remove phone....");
                        Console.Write("input name: ");
                        string name = Console.ReadLine();
                        phoneBook.RemovePhone(name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("update phone....");
                        Console.Write("input name: ");
                        string name = Console.ReadLine();
                        Console.Write("input phone: ");
                        string phone = Console.ReadLine();
                        phoneBook.UpdatePhone(name, phone);
                        break;
                    }
                case 4:
                    Console.WriteLine("search phone....");
                    Console.Write("input name: ");
                    string name2 = Console.ReadLine();
                    phoneBook.SearchPhone(name2);
                    break;
                case 5:
                    Console.WriteLine("sort phone....");
                    phoneBook.Sort();
                    break;
                case 6:
                    Console.WriteLine("display....");
                    Display();
                    break;
                case 7:
                default:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            drawMenu();
        }

        public static void Display()
        {
            Console.WriteLine("Name \t\t\t PhoneNumer");
            if (phoneBook.PhoneLists != null && phoneBook.PhoneLists.Count > 0)
            {
                foreach (PhoneItem phoneItem in phoneBook.PhoneLists)
                {
                    Console.WriteLine("{0} \t\t\t {1}", phoneItem.Name, phoneItem.PhoneNumber);
                }
            }
        }

        static void Main(string[] args)
        {
            drawMenu();
        }
    }
}