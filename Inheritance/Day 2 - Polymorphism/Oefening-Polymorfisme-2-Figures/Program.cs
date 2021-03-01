using Oefening_Polymorfisme_2_Figures.Classes;
using System;
using System.Drawing;

namespace Oefening_Polymorfisme_2_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];

            figures[0] = new Circle(new Point(10, 10), 10);
            figures[1] = new Triangle(new Point(15, 15));
            figures[2] = new Square(new Point(20, 20), 10);

            foreach (Figure figure in figures)
            {
                Console.WriteLine(figure.ToString()); // The default behavior of .ToString() is also overridable, as we have done here.
                Console.WriteLine("Circumference: " + figure.CalculateCircumference());
                Console.WriteLine("Surface: " + figure.CalculateSurface());

                Console.WriteLine("---------------------------------------");
            }


            Console.ReadLine();
        }
    }
}
