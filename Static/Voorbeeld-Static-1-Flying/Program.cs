using System;
using Voorbeeld_Static_1_Flying.Classes;

namespace Voorbeeld_Static_1_Flying
{
    class Program
    {
        static void Main(string[] args)
        {
            Vliegtuig vliegtuig = new Vliegtuig(1000);

            TankTools.TankVol(vliegtuig);


            Console.ReadLine();
        }
    }
}
