using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Server : Hardware
    {
        public Server()
        {

        }

        public Server(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
    }
}
