using System;
using System.Collections.Generic;
using System.Text;

namespace BT910_ZooManagementSystem_Practic2_Ex2
{
   public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public virtual string ViewInfo()
        {
            return $"Name: {Name}\t Age: {Age}\t Decription: {Description}";
        }
        public virtual string Speak()
        {
            return $"hello";
        }

        public Animal()
        {
        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int age, string description)
        {
            Name = name;
            Description = description;
            Age = age;
        }
    }
}
