using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(Point centerpoint, double radius)
        {
            Centerpoint = centerpoint;
            Radius = radius;
        }

        public override double CalculateCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public override double CalculateSurface()
        {
            return Radius * Radius * Math.PI;
        }

        //public override void SayWhoAmI()
        //{
        //    Console.WriteLine("I'm a circle");
        //}
    }
}
