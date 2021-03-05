using Producten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten.Classes
{
    public class Fridge : IProduct
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Fridge(string brand, string model, decimal price, string color)
        {
            BrandName = brand;
            ModelName = model;
            Price = price;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"MerkNaam: {BrandName} | ModelNaam: {ModelName} | Prijs: {Price}");
            Console.WriteLine("Color: " + Color);
        }

        public void GetColor()
        {
            Console.WriteLine("My color is: " + Color);
        }
    }
}
