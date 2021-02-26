using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Classes
{
    class Car : Vehicle
    {
        public override void WhatKindOfEnergy()
        {
            Console.WriteLine("I use gasoline as power source!");
        }
    }
}
