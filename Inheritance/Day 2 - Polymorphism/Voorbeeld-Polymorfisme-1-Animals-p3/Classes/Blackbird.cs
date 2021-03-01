using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p3.Classes
{
    public class Blackbird : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("The blackbird sings");
        }

        public void Sing()
        {
            Console.WriteLine("I am singing!");
        }
    }
}
