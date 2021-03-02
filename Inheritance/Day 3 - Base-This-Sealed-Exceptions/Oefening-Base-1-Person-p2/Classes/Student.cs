using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Base_1_Person_p2.Classes
{
    public class Student : Person
    {
        public Student() : base("Bob", 25)
        {
        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public override void IGoTo()
        {
            base.IGoTo();

            Console.WriteLine("And I learn new things!");
        }
    }
}
