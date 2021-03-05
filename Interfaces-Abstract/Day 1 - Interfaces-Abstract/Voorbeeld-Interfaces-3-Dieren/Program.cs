using System;
using Voorbeeld_Interfaces_3_Dieren.Classes;

namespace Voorbeeld_Interfaces_3_Dieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Vogel vogel = new Vogel();
            vogel.MaakGeluid();
            vogel.Vlieg();

            Console.ReadLine();
        }
    }
}
