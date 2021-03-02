using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Base_1_Animals.Classes
{
    public class Dier
    {
        public virtual void MaakGeluid()
        {
            Console.WriteLine("Het dier maakt lawaai.");
        }
    }
}
