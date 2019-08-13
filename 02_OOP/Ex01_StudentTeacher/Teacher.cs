using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_StudentTeacher
{
    class Teacher :Student
    {

        public void explain()
        {
            Console.WriteLine("Explanation begins");
        }

        public override void greet()
        {
            Console.WriteLine("Teacher hello");
        }
    }
}
