using System;
using System.Collections.Generic;
using System.Text;

namespace Immo.Classes
{
    public class RealEstateAgent
    {
        public string Name { get; set; }
        public List<Appartment> Appartments { get; set; }
        public List<House> Houses { get; set; }

        public RealEstateAgent()
        {
            Appartments = new List<Appartment>();
            Houses = new List<House>();
        }

        public void AddAppartment(Appartment appartment)
        {
            Appartments.Add(appartment);
        }

        public void AddHouse(House house)
        {
            Houses.Add(house);
        }

        public void ShowAllAppartments()
        {
            foreach (var appartment in Appartments)
            {
                appartment.WhatAreMyDetails();
            }
        }

        public void ShowAllHouses()
        {
            foreach (var house in Houses)
            {
                house.WhatAreMyDetails();
            }
        }
    }
}
