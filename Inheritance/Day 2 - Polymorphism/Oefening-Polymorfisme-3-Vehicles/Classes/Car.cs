using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Polymorfisme_3_Vehicles.Classes
{
    public class Car : Vehicle
    {
        public override void WhatAmI()
        {
            Console.WriteLine("I am a car.");
        }
    }
}
