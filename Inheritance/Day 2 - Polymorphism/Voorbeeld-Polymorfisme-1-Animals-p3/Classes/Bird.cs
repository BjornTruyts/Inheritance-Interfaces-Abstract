using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p3.Classes
{
    public class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The bird whistles.");
        }
    }
}
