using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Polymorfisme_2_Figures.Classes
{
    public class Triangle : Figure
    {
        public Triangle()
        {

        }

        public Triangle(Point centerpoint)
        {
            Centerpoint = centerpoint;
        }

        public override string ToString()
        {
            return "I am a triangle.";
        }
    }
}
