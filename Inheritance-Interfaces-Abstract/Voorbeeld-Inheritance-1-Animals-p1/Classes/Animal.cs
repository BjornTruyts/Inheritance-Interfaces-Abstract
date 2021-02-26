using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Inheritance.Classes
{
    public class Animal
    {
        public string Sound { get; set; }

        public Animal()
        {

        }

        public Animal(string sound)
        {
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine("I make the sound: " + Sound);
        }
    }
}
