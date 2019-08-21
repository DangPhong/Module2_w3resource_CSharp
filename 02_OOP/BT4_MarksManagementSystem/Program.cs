using System;
using System.Collections;
namespace MarksManagementSystem
{
    class Program
    {
        public static int id = 0;
        public static ArrayList studentList = new ArrayList();
        public static void Draw()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. insert new student...");
                Console.WriteLine("2. view list of student...");
                Console.WriteLine("3. average mark...");
                Console.WriteLine("4. exit");
                Console.Write("option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option > 4 || 0 >= option);
            Process(option);
        }

        public static void Process(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("insert new student...");
                        id++;
                        createStudent();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("view list of student...");
                        DisplayInfo();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("average mark...");
                        AverageStudentMark();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            Draw();
        }

        static void createStudent()
        {
            StudentMark student = new StudentMark();
            student.Id = id;
            Console.Write("input fullname: ");
            student.Fullname = Console.ReadLine();
            Console.Write("input class: ");
            student.Class = Console.ReadLine();
            Console.Write("input semester: ");
            student.Semester = int.Parse(Console.ReadLine());
            Console.WriteLine("input mark: ");
            for (int i = 0; i < student.SubjectMarkList.Length; i++)
            {
                Console.WriteLine("input mark object {0}", i + 1);
                student.SubjectMarkList[i] = int.Parse(Console.ReadLine());
            }
            studentList.Add(student);
        }

        public static void DisplayInfo()
        {
            foreach (StudentMark student in studentList)
            {
                Console.WriteLine(student.Display());
            }
        }

        public static void AverageStudentMark()
        {
            foreach (StudentMark student in studentList)
            {
                student.AveCal();
            }
        }
        static void Main(string[] args)
        {
            Draw();
        }
    }
}
