using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Employee : Person
    {
        public Employer Boss { get; set; }

        public Employee(string givenName)
        {
            GivenName = givenName;
        }

        public void Work()
        {
            Console.WriteLine($"{GivenName}: I'm working on the task.");
        }
    }
}
