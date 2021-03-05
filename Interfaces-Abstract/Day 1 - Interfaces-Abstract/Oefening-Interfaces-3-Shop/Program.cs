using Producten.Classes;
using Producten.Interfaces;
using System;

namespace Producten
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            var fridge = new Fridge("KoelerMan", "X850", 180, "White");

            var microWave = new MicroWave("Philips", "Z50", 100, 950 );

            var gsm = new Gsm("Nokia", "Stone of death", 350, true);

            shop.AddProduct(fridge);
            shop.AddProduct(microWave);
            shop.AddProduct(gsm);

            shop.AddProducts(fridge, microWave);

            shop.ShowAllProductDetails();

            Console.ReadLine();
        }
    }
}
