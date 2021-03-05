using Producten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten.Classes
{
    public class Gsm : IProduct
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public bool WaterProof { get; set; }

        public Gsm(string brand, string model, decimal price, bool waterProof)
        {
            BrandName = brand;
            ModelName = model;
            Price = price;
            WaterProof = waterProof;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"MerkNaam: {BrandName} | ModelNaam: {ModelName} | Prijs: {Price}");
            string waterProof = WaterProof == true ? "Yes": "No";
            Console.WriteLine("Waterproof: " + waterProof);
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }
    }
}
