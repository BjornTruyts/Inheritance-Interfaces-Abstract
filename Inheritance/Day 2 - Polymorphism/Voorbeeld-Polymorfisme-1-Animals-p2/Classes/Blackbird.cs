﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Polymorfisme_1_Animals_p2.Classes
{
    public class Blackbird : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("The blackbird sings");
        }
    }
}
