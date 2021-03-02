using Oefening_BaseThis_2_Horeca.Classes;
using System;

namespace Oefening_BaseThis_2_Horeca
{
    class Program
    {
        static void Main(string[] args)
        {
            CityHoreca cityHoreca = new CityHoreca();

            cityHoreca.AddHoreca(new Hotel("The Plaza Hotel", "768 5th Ave, New York"));
            cityHoreca.AddHoreca(new Hotel("Marina Bay Sands", "10 Bayfront Ave, Singapore"));
            cityHoreca.AddHoreca(new Restaurant("Het Gerecht", "Amerikalei 20, Antwerp"));
            cityHoreca.AddHoreca(new Restaurant("No Worries", "Kribbestraat 20, Antwerp"));
            cityHoreca.AddHoreca(new Cafe("Bier Central", "De Keyserlei 25, 2018 Antwerpen"));
            cityHoreca.AddHoreca(new Bistro("Appelmans", "Papenstraatje 1, Antwerp"));

            while (true)
            {
                Console.Write("Type a name to search for: ");

                string readValue = Console.ReadLine();
                cityHoreca.SearchByName(readValue);
            };
        }
    }
}
