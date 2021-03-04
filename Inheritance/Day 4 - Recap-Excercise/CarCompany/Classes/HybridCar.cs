using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public sealed class HybridCar : Car
    {
        public HybridCar(string brand, string model, int constructionYear) : base(brand, model, constructionYear)
        {

        }

        public override string GetDetails()
        {
            return $"Type: Hybrid | Brand: {Brand} | Model: {Model} | Construction Year: {ConstructionYear}.";
        }
    }
}
