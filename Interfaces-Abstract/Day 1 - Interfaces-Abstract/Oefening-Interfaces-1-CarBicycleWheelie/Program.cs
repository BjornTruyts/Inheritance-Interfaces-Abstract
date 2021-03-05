using Oefening_Interfaces_1_CarBicycleWheelie.Classes;
using System;

namespace Oefening_Interfaces_1_CarBicycleWheelie
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Ride();
            car.Brake();

            Console.WriteLine("--------------------");

            bicycle.Ride();
            bicycle.Wheelie();
            bicycle.Brake();


            Console.ReadLine();
        }
    }
}
