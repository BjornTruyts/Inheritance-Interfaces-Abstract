using System;
using Voorbeeld_Static_2_Calculate.Classes;
using Voorbeeld_Static_2_Calculate.Extensions;

namespace Voorbeeld_Static_2_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Berekening berekening = new Berekening();
            berekening.Resultaat = 15;

            berekening.VoegToeAanResultaat(4);

            Console.WriteLine(berekening.Resultaat);


            Console.ReadLine();
        }
    }
}
