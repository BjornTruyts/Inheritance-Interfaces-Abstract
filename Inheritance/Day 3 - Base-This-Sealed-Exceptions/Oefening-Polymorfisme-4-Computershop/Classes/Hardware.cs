using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Hardware
    {
        public string Brand { get; set; }
        public double Price { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Price: {Price} Euro");
        }
    }
}
