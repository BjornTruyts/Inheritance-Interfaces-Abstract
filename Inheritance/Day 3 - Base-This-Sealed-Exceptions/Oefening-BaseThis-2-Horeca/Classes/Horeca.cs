using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_BaseThis_2_Horeca.Classes
{
    public class Horeca
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Horeca(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} | Address: {Address}");
        }
    }
}
