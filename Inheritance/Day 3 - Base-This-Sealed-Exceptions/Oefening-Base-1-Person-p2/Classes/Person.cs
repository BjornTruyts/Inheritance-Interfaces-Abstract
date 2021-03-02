using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Base_1_Person_p2.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void IGoTo()
        {
            Console.WriteLine("I go to the Harvard University.");
        }

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}, and I'm {Age} old.");
        }
    }
}
