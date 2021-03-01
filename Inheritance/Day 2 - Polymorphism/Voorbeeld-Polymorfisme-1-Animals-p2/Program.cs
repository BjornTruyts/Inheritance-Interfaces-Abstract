using System;
using Voorbeeld_Polymorfisme_1_Animals_p2.Classes;

namespace Voorbeeld_Polymorfisme_1_Animals_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal bird = new Bird();
            Animal blackbird = new Blackbird();
            Animal sparrow = new Sparrow();

            animal.MakeSound();
            bird.MakeSound();
            blackbird.MakeSound();
            sparrow.MakeSound();

            Console.WriteLine("-------------------------");

            Bird blackbird2 = new Blackbird();
            Bird sparrow2 = new Sparrow();
            blackbird2.MakeSound();
            sparrow2.MakeSound();

            ///* This gives an error, you can't assign classes as its siblings, only parents. */
            //Blackbird sparrow3 = new Sparrow();


            Console.ReadLine();
        }
    }
}
