using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square()
        {

        }

        public Square(Point centerpoint, double side)
        {
            Centerpoint = centerpoint;
            Side = side;
        }

        public override double CalculateCircumference() // Omtrek
        {
            return Side * 4;
        }

        public override double CalculateSurface() // Oppervlakte
        {
            return Math.Pow(Side, 2); // OR Side * Side
        }

        //public override void SayWhoAmI()
        //{
        //    Console.WriteLine("I'm a square");
        //}
    }
}
