using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p3.Classes
{
    public class Sparrow : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("The sparrow chirps");
        }

        public void Chirp()
        {
            Console.WriteLine("I am chriping!");
        }
    }
}
