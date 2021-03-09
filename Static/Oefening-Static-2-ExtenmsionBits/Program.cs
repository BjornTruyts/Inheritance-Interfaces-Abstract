using System;
using Oefening_Static_2_ExtenmsionBits.Extensions;

namespace Oefening_Static_2_ExtenmsionBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 20;
            bool isGreater = myNumber.IsGreaterThan(15);
            Console.WriteLine("Is greater? " + isGreater);

            string first = "Hello";
            string second = "There";
            string combined = first.AddString(second);
            Console.WriteLine(combined);

            string hi = "Hello!";
            string reverseHi = hi.Reverse();
            Console.WriteLine(reverseHi);

            Console.ReadLine();
        }
    }
}
