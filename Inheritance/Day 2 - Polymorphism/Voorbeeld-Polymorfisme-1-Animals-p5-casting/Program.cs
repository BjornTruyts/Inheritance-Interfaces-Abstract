using System;
using Voorbeeld_Polymorfisme_1_Animals_p5_casting.Classes;

namespace Voorbeeld_Polymorfisme_1_Animals_p5_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Sparrow();

            Console.WriteLine((Sparrow)sparrow);    // Sparrow-object
            Console.WriteLine((Blackbird)sparrow);  // InvalidCastException


            Console.ReadLine();
        }
    }
}
