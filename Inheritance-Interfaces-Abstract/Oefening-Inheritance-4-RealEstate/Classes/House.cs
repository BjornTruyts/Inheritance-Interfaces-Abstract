using System;
using System.Collections.Generic;
using System.Text;

namespace Immo.Classes
{
    public class House : RealEstate
    {
        public bool HasSolarpanels { get; set; }

        public House()
        {

        }

        public House(string address, int numberOfRooms, double price)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
            Price = price;
        }
    }
}
