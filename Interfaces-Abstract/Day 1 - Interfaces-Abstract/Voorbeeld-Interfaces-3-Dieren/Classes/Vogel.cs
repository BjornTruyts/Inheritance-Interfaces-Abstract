using System;
using System.Collections.Generic;
using System.Text;
using Voorbeeld_Interfaces_3_Dieren.Intefaces;

namespace Voorbeeld_Interfaces_3_Dieren.Classes
{
    public class Vogel : Dier, IKanVliegen
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("De vogel tjirpt");
        }

        public void Vlieg()
        {
            Console.WriteLine("Het vogeltje vliegt.");
        }
    }
}
