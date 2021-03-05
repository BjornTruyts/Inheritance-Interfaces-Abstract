using Oefening_Interfaces_1_CarBicycleWheelie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Interfaces_1_CarBicycleWheelie.Classes
{
    class Car : ICanRide, ICanBrake
    {
        public void Ride()
        {
            Console.WriteLine("I am riding a car.");
        }

        public void Brake()
        {
            Console.WriteLine("I am hitting the car's breaks.");
        }
    }
}
