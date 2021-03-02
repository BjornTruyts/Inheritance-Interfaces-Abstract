using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Base_1_Animals.Classes
{
    public class Dier
    {
        public string Geluid { get; set; }

        public Dier(string geluid)
        {
            Geluid = geluid;
        }

        public virtual void MaakGeluid()
        {
            Console.WriteLine("Het dier maakt lawaai.");
        }
    }
}
