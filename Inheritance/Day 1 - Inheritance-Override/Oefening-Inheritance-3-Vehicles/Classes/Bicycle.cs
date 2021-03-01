using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Classes
{
    class Bicycle : Vehicle
    {
        public override void WhatKindOfEnergy()
        {
            Console.WriteLine("I use kinetic energy as power source!");
        }
    }
}
