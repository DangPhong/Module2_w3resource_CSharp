using System;

namespace AnimalMove_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.canMove());

            Cat tom = new Cat();
            Console.WriteLine(tom.canMove());
        }
    }
}
