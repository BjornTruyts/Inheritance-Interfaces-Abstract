using Producten.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten.Classes
{
    public class MicroWave : IProduct
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public int Wattage { get; set; }

        public MicroWave(string brand, string model, decimal price, int wattage)
        {
            BrandName = brand;
            ModelName = model;
            Price = price;
            Wattage = wattage;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"MerkNaam: {BrandName} | ModelNaam: {ModelName} | Prijs: {Price}");
            Console.WriteLine("Wattage: " + Wattage);
        }

        public void WarmUp()
        {
            Console.WriteLine("Warm Up...");
        }
    }
}
