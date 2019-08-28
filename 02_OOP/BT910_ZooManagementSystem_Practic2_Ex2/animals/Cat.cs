using System;
using System.Collections.Generic;
using System.Text;

namespace BT910_ZooManagementSystem_Practic2_Ex2.animals
{
    class Cat : Animal
    {
        public Cat() : base()
        {

        }
        public Cat(string name) : base(name)
        {
            Name = name;
        }

        public Cat(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public Cat(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public override string Speak()
        {
            return $"Cat speak: meo meoooo";
        }

        public override string ViewInfo()
        {
            return base.ViewInfo();
        }
    }
}
