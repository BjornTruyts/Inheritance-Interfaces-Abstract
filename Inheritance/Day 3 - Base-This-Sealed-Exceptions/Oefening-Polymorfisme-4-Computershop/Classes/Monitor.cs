using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Monitor : Hardware
    {
        public Monitor()
        {

        }

        public Monitor(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
    }
}
