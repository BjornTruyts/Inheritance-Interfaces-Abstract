using System;
using System.Collections.Generic;
using System.Text;

namespace Immo.Classes
{
    public class Appartment : RealEstate
    {
        public int BusNumber { get; set; }
        public bool HasElevator { get; set; }

        public Appartment()
        {

        }

        public Appartment(string address, int numberOfRooms, double price)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
            Price = price;
        }
    }
}
