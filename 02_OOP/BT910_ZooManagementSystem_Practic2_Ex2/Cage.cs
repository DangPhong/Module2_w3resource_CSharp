using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BT910_ZooManagementSystem_Practic2_Ex2
{
    class Cage
    {
        public int CageNumber { get; set; }
        public ArrayList AnimalList { get; set; }

        Animal animal = new Animal();
        public void AddAnimal(Animal a)
        {
            string name = a.Name;
            int age = a.Age;
            string description = a.Description;

            AnimalList.Add(a);
        }

        public void removeAnimal(string name)
        {
            if (name == animal.Name)
            {
                AnimalList.Remove(animal);
            }
        }
    }
}
