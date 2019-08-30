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

      //  Animal animal = new Animal();
        public void AddAnimal(Animal animal)
        {
            AnimalList.Add(animal);
        }

        public void removeAnimal(string name)
        {
           
        }
    }
}
