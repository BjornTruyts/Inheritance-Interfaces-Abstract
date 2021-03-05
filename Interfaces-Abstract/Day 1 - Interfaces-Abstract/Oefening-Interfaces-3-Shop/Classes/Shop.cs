using Producten.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Producten.Classes
{
    public class Shop
    {
        public List<IProduct> Products { get; set; }

        public Shop()
        {
            Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public void AddProducts(params IProduct[] products)
        {
            Products.AddRange(products);
        }

        public void ShowAllProductDetails()
        {
            foreach (var product in Products)
            {
                product.ShowDetails();
                Console.WriteLine("----------------");
            }
        }
    }
}
