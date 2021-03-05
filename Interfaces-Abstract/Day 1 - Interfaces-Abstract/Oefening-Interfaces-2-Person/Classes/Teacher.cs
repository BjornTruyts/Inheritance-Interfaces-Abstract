using Oefening_Interfaces_2_Person.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Interfaces_2_Person.Classes
{
    class Teacher : Person, IConsoleWriteable, ITeach, ILearn
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }

        public void Learn()
        {
            Console.WriteLine("I'm learning");
        }

        public void Teach()
        {
            Console.WriteLine("I Teach");
        }

        public void ToConsoleString()
        {
            Console.WriteLine($"My name is {Name}, I'm {Age} years old and I'm a Teacher.");
        }
    }
}
