using System;

namespace Ex01_StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.greet();

            Student student = new Student();
            student.Age = 21;
            student.greet();
            student.showAge();

            Teacher teacher = new Teacher();
            teacher.Age = 30;
            teacher.greet();
            teacher.showAge();
            teacher.explain();
        }
    }
}
