using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Desktop : Hardware
    {
        public Desktop()
        {

        }

        public Desktop(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
    }
}
