using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Static_1_Flying_3.Classes
{
    public class Vliegtuig
    {
        public static int AantalVliegtuigenInDeLucht { get; set; }

        static Vliegtuig() //Only gets called the very first time an object gets instantiated, and not anymore for the next instantiations.
        {
            AantalVliegtuigenInDeLucht = 0;
        }

        public void StijgOp()
        {
            AantalVliegtuigenInDeLucht++;
        }

        public void Land()
        {
            AantalVliegtuigenInDeLucht--;
        }
    }
}
