using Oefening_Polymorfisme_3_Vehicles.Classes;
using System;

namespace Oefening_Polymorfisme_3_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = new Car();
            vehicles[1] = new Bicycle();
            vehicles[2] = new Boat();
            vehicles[3] = new RowingBoat();

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.WhatAmI();

                RowingBoat rowboat = vehicle as RowingBoat;

                if (rowboat != null) //Check if the cast was successful. (null means it failed)
                {
                    rowboat.RowTheBoat(); //Cast was successful, so we can call RowTheBoat();
                }

                //if (vehicle is RowingBoat) //Another way to check if it is cast-able.
                //{
                //    ((RowingBoat)vehicle).RowTheBoat();

                //}
            }

            Console.ReadLine();
        }
    }
}