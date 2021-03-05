using Oefening_Interfaces_1_CarBicycleWheelie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Interfaces_1_CarBicycleWheelie.Classes
{
    class Bicycle : ICanRide, ICanBrake, ICanWheelie
    {
        public void Ride()
        {
            Console.WriteLine("I'm riding a bicycle.");
        }
        public void Brake()
        {
            Console.WriteLine("I am hitting the breaks.");
        }
        public void Wheelie()
        {
            Console.WriteLine("I'm doing a wheelie!");
        }
    }
}
