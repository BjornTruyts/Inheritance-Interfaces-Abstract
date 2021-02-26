using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Figure
    {
        public Point Centerpoint { get; set; }

        public Figure()
        {

        }

        public Figure(Point centerpoint)
        {
            Centerpoint = centerpoint;
        }

        public double CalculateDistance(Point point)
        {
            double distance = Math.Pow(Centerpoint.X - point.X, 2) + Math.Pow(Centerpoint.Y - point.Y, 2);

            distance = Math.Sqrt(distance);

            return distance;
        }

        public string CenterpointAsString()
        {
            return $"This figure's center point is: {Centerpoint}";
        }
    }
}
