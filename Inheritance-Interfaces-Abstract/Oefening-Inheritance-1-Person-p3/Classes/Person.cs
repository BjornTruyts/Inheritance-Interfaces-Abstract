using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Person
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }

        public Person()
        {

        }

        public virtual void WhatIsMyTask()
        {
            Console.WriteLine("I do nothing.");
        }
    }
}
