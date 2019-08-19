using System;

namespace HeThongQuanLySdt
{
    class Program
    {
        public static int option = 0;

        public static PhoneBook phone = new PhoneBook();

        public static void drawMenu()
        {
            do
            {
                Console.WriteLine("1. insert phone ");
                Console.WriteLine("2. remove phone  ");
                Console.WriteLine("3. update phone ");
                Console.WriteLine("4. search phone ");
                Console.WriteLine("5. sort ");
                Console.WriteLine("6. exit ");
                Console.Write("Option: ");
            } while (option < 0 || option > 6);
        }

        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        phone.InsertPhone();
                        break;
                    }
                case 2:
                    {
                        phone.RemovePhone(string name);
                        break;
                    }
                case 3:
                    {
                        phone.updatePhone();
                        break;
                    }
                case 4:
                    phone.searchPhone();
                    break;
                case 5:
                    phone.sort();
                    break();
                case 6:
                    Environment.Exit(Environment.ExitCode());

                    break;
            }
            drawMenu();
        }
        static void Main(string[] args)
        {
            drawMenu();
            do
            {
                Process(option);
            } while (option != 6);

        }
    }
}