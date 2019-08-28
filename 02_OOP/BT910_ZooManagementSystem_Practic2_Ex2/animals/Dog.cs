using System;
using System.Collections.Generic;
using System.Text;

namespace BT910_ZooManagementSystem_Practic2_Ex2.animals
{
    class Dog : Animal
    {
        public Dog() : base()
        {

        }
        public Dog(string name) : base(name)
        {
            Name = name;
        }

        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public Dog(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public override string Speak()
        {
            return $"Dog speak: gau gauuuu";
        }

        public override string ViewInfo()
        {
            return base.ViewInfo();
        }
    }
}
