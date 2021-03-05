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
            //boeing.NavigeerNaarTarmac(); //Methode niet gekend binnen IkKanVliegen


            Vliegtuig airbus = new Vliegtuig();
            airbus.Vlieg(500);
            airbus.NavigeerNaarTarmac(); //Methode is gekend omdat Vliegtuig deze methode bevat.

            Console.WriteLine(airbus as IKanVliegen);

            var bbb = boeing as Vliegtuig;
            bbb.NavigeerNaarTarmac();

            Console.ReadLine();
        }
    }
}
