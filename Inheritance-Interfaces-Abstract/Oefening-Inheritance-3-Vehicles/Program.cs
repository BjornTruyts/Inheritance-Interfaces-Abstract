using System;
using Vehicles.Classes;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            vehicle.WhatKindOfEnergy();
            car.WhatKindOfEnergy();
            bicycle.WhatKindOfEnergy();



            Console.ReadLine();
        }
    }
}
