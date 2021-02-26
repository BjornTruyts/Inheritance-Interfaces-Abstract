using System;
using System.Collections.Generic;
using System.Text;

namespace Immo.Classes
{
    public class RealEstate
    {
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public double Price { get; set; }

        public RealEstate()
        {

        }

        public RealEstate(string address, int numberOfRooms, double price)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
            Price = price;
        }

        public void WhatAreMyDetails()
        {
            Console.WriteLine($"Address: {Address} || Rooms: {NumberOfRooms} || Price: {Price}");
        }
    }
}
