using Oefening_Interfaces_1_Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Interfaces_1_Animals.Classes
{
    public class Vliegtuig : IKanVliegen
    { 
        public void Vlieg(int hoogte)
        {
            Console.WriteLine($"Ik vlieg {hoogte} hoog!");
        }

        public void NavigeerNaarTarmac()
        {
            Console.WriteLine("Ik navigeer naar tarmac.");
        }
    }
}
