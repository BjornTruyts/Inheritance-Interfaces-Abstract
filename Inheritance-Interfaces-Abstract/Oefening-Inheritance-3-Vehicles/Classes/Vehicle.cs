using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Classes
{
    class Vehicle
    {
        public virtual void WhatKindOfEnergy()
        {
            Console.WriteLine("I don't use energy.");
        }
    }
}
