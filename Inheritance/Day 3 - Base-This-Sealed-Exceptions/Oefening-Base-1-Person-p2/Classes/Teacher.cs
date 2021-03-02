using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Base_1_Person_p2.Classes
{
    public class Teacher : Person
    {
        public Teacher() : base("John", 42)
        {

        }

        public Teacher(string name, int age) : base(name, age)
        {

        }

        public override void IGoTo()
        {
            base.IGoTo();

            Console.WriteLine("And I teach students new things!");
        }
    }
}
