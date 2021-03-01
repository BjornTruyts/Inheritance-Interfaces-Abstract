using System;
using Voorbeeld_Polymorfisme_1_Animals_p4_isas.Classes;

namespace Voorbeeld_Polymorfisme_1_Animals_p4_isas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------| IS |--------------");

            Sparrow sparrow = new Sparrow();

            Console.WriteLine(sparrow is Bird);      // true
            Console.WriteLine(sparrow is Sparrow);   // true
            Console.WriteLine(sparrow is Blackbird); // false

            Console.WriteLine("***");

            Bird sparrow2 = new Sparrow();

            Console.WriteLine(sparrow2 is Bird);      // true
            Console.WriteLine(sparrow2 is Sparrow);   // true
            Console.WriteLine(sparrow2 is Blackbird); // false

            Console.WriteLine("--------------| AS |--------------");

            Console.WriteLine(sparrow2 as Bird);      // Sparrow-object
            Console.WriteLine(sparrow2 as Sparrow);   // Sparrow-object
            Console.WriteLine(sparrow2 as Blackbird); // null


            Console.ReadLine();
        }
    }
}
