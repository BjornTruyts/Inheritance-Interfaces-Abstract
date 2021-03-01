using Oefening_Inheritance.Classes;
using System;
using System.Drawing;

namespace Oefening_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(5, 5));
            Triangle triangle = new Triangle(new Point(15, 15));

            Console.WriteLine("Figure: " + figure.CenterpointAsString());
            Console.WriteLine("The distance of figure to a point is: " + figure.CalculateDistance(new Point(10, 10)));

            Console.WriteLine();

            Console.WriteLine("Triangle: " + triangle.CenterpointAsString());
            Console.WriteLine("The distance between the figure and triangle is: " + figure.CalculateDistance(triangle.Centerpoint));

            Console.ReadLine();
        }
    }
}
