using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_StudentTeacher
{
    class Person
    {
        private int age;

        public int Age { get => age; set => age = value; }

        public virtual void greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
