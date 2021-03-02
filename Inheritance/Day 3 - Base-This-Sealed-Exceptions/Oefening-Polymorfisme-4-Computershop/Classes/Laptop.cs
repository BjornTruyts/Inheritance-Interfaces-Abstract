using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Laptop : Hardware
    {
        public Laptop()
        {

        }

        public Laptop(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
    }
}
