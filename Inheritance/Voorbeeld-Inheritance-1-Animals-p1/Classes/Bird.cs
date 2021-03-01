using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Inheritance.Classes
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public Bird(string sound)
        {
            Sound = sound;
        }
    }
}
