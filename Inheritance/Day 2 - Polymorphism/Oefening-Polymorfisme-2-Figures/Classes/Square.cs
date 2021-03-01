using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Polymorfisme_2_Figures.Classes
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

        public override string ToString()
        {
            return "I am a square.";
        }
    }
}
