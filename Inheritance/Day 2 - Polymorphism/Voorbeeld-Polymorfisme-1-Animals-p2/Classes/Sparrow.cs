using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p2.Classes
{
    public class Sparrow : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("The sparrow chirps");
        }
    }
}
