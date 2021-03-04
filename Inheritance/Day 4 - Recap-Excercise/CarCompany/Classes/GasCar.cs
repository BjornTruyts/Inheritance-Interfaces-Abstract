using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public sealed class GasCar : Car
    {
        public GasCar(string brand, string model, int constructionYear) : base(brand, model, constructionYear)
        {

        }

        public override string GetDetails()
        {
            return $"Type: Gas | Brand: {Brand} | Model: {Model} | Construction Year: {ConstructionYear}.";
        }
    }
}
