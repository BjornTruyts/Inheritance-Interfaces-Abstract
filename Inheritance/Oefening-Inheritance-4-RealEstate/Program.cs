using System;
using Immo.Classes;


namespace Immo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateAgent immo = new RealEstateAgent();

            Appartment app1 = new Appartment("Appartementstraat 10", 1, 180000);
            Appartment app2 = new Appartment("Appartementstraat 15", 3, 320000);

            House house1 = new House("Huisstraat 10", 1, 220000);
            House house2 = new House("Huisstraat 31", 3, 380000);

            immo.AddAppartment(app1);
            immo.AddAppartment(app2);

            immo.AddHouse(house1);
            immo.AddHouse(house2);

            Console.WriteLine("All appartments for sale:");
            immo.ShowAllAppartments();

            Console.WriteLine("----------------");

            Console.WriteLine("All houses for sale:");
            immo.ShowAllHouses();

            Console.ReadLine();
        }
    }
}
