using System;
using Voorbeeld_Base_1_Animals.Classes;

namespace Voorbeeld_Base_1_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Vogel vogel = new Vogel();

            vogel.MaakGeluid();

            Console.ReadLine();
        }
    }
}
