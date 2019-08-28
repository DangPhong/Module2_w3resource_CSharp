using System;
using System.Collections.Generic;
using System.Text;

namespace BT910_ZooManagementSystem_Practic2_Ex2.animals
{
    class Tiger : Animal
    {
        public Tiger() : base()
        {

        }
        public Tiger(string name) : base(name)
        {
            Name = name;
        }

        public Tiger(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public Tiger(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public override string Speak()
        {
            return $"Tiger: Gammmmm";
        }

        public override string ViewInfo()
        {
            return base.ViewInfo();
        }


    }
}
