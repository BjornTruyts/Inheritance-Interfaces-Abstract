using System;
using Voorbeeld_Inheritance.Classes;

namespace Voorbeeld_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("hello");
            Bird bird = new Bird("tsjirp");
            Fish fish = new Fish("blub");

            animal.MakeSound();
            bird.MakeSound();
            fish.MakeSound();

            Console.ReadLine();
        }
    }
}
