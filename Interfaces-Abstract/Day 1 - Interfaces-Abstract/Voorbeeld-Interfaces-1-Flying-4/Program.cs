using Oefening_Interfaces_1_Animals.Classes;
using Oefening_Interfaces_1_Animals.Interfaces;
using System;

namespace Oefening_Interfaces_1_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IKanVliegen boeing = new Vliegtuig();
            boeing.Vlieg(500);
            //boeing.StartMotor(); //Methode niet gekend binnen IkKanVliegen

            Vliegtuig airbus = new Vliegtuig();
            //airbus.Vlieg(500); //Methode expliciet geimplementeerd voor interface, dus niet toegankelijk hier.
            airbus.NavigeerNaarTarmac();



            Console.ReadLine();
        }
    }
}
