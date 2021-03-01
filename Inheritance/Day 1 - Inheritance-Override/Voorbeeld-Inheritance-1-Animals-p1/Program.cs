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

            animal.MakeSound();
            bird.MakeSound();

            Console.ReadLine();
        }
    }
}
