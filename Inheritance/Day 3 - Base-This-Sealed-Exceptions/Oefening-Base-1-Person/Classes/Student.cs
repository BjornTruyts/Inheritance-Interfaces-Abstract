﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Base_1_Person.Classes
{
    public class Student : Person
    {
        public override void IGoTo()
        {
            base.IGoTo();

            Console.WriteLine("And I learn new things!");
        }
    }
}
