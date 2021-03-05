using System;
using System.Collections.Generic;
using System.Text;

namespace Producten.Interfaces
{
    public interface IProduct
    {
        string BrandName { get; set; }
        string ModelName { get; set; }
        decimal Price { get; set; }

        void ShowDetails();
    }
}
