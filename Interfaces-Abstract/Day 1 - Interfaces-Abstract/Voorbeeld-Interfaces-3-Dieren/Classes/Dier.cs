using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Interfaces_3_Dieren.Classes
{
    public class Dier
    {
        public string Geluid { get; set; }

        public virtual void MaakGeluid()
        {
            Console.WriteLine("Het dier maakt geluid.");
        }
    }
}
