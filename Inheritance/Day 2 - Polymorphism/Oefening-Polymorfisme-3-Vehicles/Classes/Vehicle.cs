using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_3_Vehicles.Classes
{
    public class Vehicle
    {
        public virtual void WhatAmI()
        {
            Console.WriteLine("I am a vehicle.");
        }
    }
}
