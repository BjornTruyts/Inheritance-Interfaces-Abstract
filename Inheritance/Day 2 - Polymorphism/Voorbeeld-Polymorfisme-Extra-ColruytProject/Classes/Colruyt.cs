using System;
using System.Collections.Generic;
using System.Text;

namespace ColruytProject.Classes
{
    public class Colruyt
    {
        Product[] _producten;

        public Colruyt()
        {
            _producten = new Product[2];
            _producten[0] = new Vlees();
            _producten[1] = new Groent(); 
        }

        public void ScanProducten()
        {
            foreach (Product product in _producten)
            {
                Console.WriteLine(product + " gescand");

                if(product is Groent)
                {
                    ((Groent)product).OpAfslag();
                }
            }
        }
    }
}
