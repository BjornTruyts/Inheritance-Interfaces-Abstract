using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_3_Vehicles.Classes
{
    public class RowingBoat : Boat
    {
        public override void WhatAmI()
        {
            Console.WriteLine("I am a rowing boat.");
        }

        public void RowTheBoat()
        {
            Console.WriteLine("Row row row your boat.");
        }
    }
}
