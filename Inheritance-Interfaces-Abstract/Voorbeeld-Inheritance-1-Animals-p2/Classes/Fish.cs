using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Inheritance.Classes
{
    public class Fish : Animal
    {
        public Fish()
        {

        }

        public Fish(string sound)
        {
            Sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The fish goes " + Sound);
        }
    }
}
