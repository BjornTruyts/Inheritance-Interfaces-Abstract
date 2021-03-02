using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Base_1_Animals.Classes
{
    public class Vogel : Dier
    {
        public Vogel() : base("tjsielp")
        {

        }

        public Vogel(string geluid) : base(geluid)
        {

        }

        public override void MaakGeluid()
        {
            base.MaakGeluid();

            Console.WriteLine("De vogel fluit.");
            Console.WriteLine(Geluid);
        }
    }
}
