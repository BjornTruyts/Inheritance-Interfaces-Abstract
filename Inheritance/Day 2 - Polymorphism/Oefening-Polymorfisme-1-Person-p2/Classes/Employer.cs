using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_1_Person_p2.Classes
{
    class Employer : Person
    {
        public override void WhatIsMyTask()
        {
            Console.WriteLine("My task is to give employees tasks!");
        }
    }
}
