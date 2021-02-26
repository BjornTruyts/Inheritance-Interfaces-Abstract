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
            Circle circle = new Circle(new Point(10, 10), 10);
            Square square = new Square(new Point(20, 20), 10);

            //Console.WriteLine("Figure: " + figure.CenterpointAsString());
            Console.WriteLine("The distance of figure to a point is: " + figure.CalculateDistance(new Point(10, 10)));

            Console.WriteLine();

            //Console.WriteLine("Triangle: " + triangle.CenterpointAsString());
            Console.WriteLine("The distance between the figure and triangle is: " + figure.CalculateDistance(triangle.Centerpoint));

            Console.WriteLine();

            //Console.WriteLine("Circle: " + circle.CenterpointAsString());
            Console.WriteLine("The distance between the figure and circle is: " + figure.CalculateDistance(circle.Centerpoint));
            Console.WriteLine("Circumference: " + circle.CalculateCircumference());
            Console.WriteLine("Surface: " + circle.CalculateSurface());

            Console.WriteLine();

            //Console.WriteLine("Square: " + square.CenterpointAsString());
            Console.WriteLine("The distance between the figure and circle is: " + figure.CalculateDistance(square.Centerpoint));
            Console.WriteLine("Circumference: " + square.CalculateCircumference());
            Console.WriteLine("Surface: " + square.CalculateSurface());


            //Console.WriteLine("-------------");

            //figure.SayWhoAmI();
            //triangle.SayWhoAmI();
            //circle.SayWhoAmI();
            //square.SayWhoAmI();

            Console.ReadLine();
        }
    }
}
