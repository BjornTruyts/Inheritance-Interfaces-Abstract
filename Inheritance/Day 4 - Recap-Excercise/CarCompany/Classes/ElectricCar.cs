using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public sealed class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int constructionYear) : base(brand, model, constructionYear)
        {

        }

        public override string GetDetails()
        {
            return $"Type: Electric | Brand: {Brand} | Model: {Model} | Construction Year: {ConstructionYear}.";
        }
    }
}
