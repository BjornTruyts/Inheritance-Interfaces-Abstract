using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_3_Vehicles.Classes
{
    class Bicycle : Vehicle
    {
        public override void WhatAmI()
        {
            Console.WriteLine("I am a Bicycle.");
        }
    }
}
