using System;
using Voorbeeld_Static_1_Flying_3.Classes;

namespace Voorbeeld_Static_1_Flying_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vliegtuig boeing = new Vliegtuig();
            Vliegtuig airbus = new Vliegtuig();

            Console.WriteLine(Vliegtuig.AantalVliegtuigenInDeLucht); // 0

            boeing.StijgOp();

            Console.WriteLine(Vliegtuig.AantalVliegtuigenInDeLucht); // 1

            airbus.StijgOp();

            Console.WriteLine(Vliegtuig.AantalVliegtuigenInDeLucht); // 2

            boeing.Land();

            Console.WriteLine(Vliegtuig.AantalVliegtuigenInDeLucht); // 1

            airbus.Land();

            Console.WriteLine(Vliegtuig.AantalVliegtuigenInDeLucht); // 0



            Console.ReadLine();
        }
    }
}
