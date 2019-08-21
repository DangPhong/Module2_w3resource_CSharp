using System;
using System.Collections;
namespace BT5_StudentManagementSystem
{
    class Program
    {
        static int id = 0;
        public static ArrayList studentList = new ArrayList();
        public static void DrawMenu()
        {

            int option = 0;
            do
            {
                Console.WriteLine("-----StudentManagementSystem-----");
                Console.WriteLine("1. insert new student");
                Console.WriteLine("2. view list of student");
                Console.WriteLine("3. search student");
                Console.WriteLine("4. exit");
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
                        Console.WriteLine("1. insert new student");
                        InsertStudent();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("2. view list of student");
                        DisplayInfo();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("3. search student");
                        Console.Write("input name to search: ");
                        string name = Console.ReadLine();
                        SearchStudent(name);
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

        static void InsertStudent()
        {
            Student student = new Student();
            student.Id = id++;
            Console.Write("input fullname: ");
            student.FullName = Console.ReadLine();
            Console.Write("input date of birth: ");
            student.DateOfBirth = Console.ReadLine();
            Console.Write("input native: ");
            student.Native = Console.ReadLine();
            Console.Write("input class: ");
            student.ClassName = Console.ReadLine();
            Console.Write("input phone number: ");
            student.PhoneNo = Console.ReadLine();
            Console.Write("input mobile: ");
            student.Mobile = int.Parse(Console.ReadLine());

            studentList.Add(student);
        }





        static void Main(string[] args)
        {
            DrawMenu();
        }

        static void DisplayInfo()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.Display());
            }
        }

        static void SearchStudent(string name)
        {
            foreach (Student student in studentList)
            {
                if (student.FullName == name)
                {
                    Console.WriteLine(student.Display());
                }
                else
                {
                    Console.WriteLine("no found");
                }
            }
        }
    }
}
