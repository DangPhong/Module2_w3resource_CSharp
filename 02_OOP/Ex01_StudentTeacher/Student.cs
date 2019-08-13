using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_StudentTeacher
{
    class Student : Person
    {
        public override void greet()
        {
            Console.WriteLine("Student hello");
        }

        public void showAge()
        {
            Console.WriteLine("My age is: {0} ", Age);
        }
    }
}
