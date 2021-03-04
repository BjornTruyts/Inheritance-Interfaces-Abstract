using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }

        public Car(string brand, string model, int constructionYear)
        {
            Brand = brand;
            Model = model;
            ConstructionYear = constructionYear;
        }

        public virtual string GetDetails()
        {
            return $"Brand: {Brand} | Model: {Model} | Construction Year: {ConstructionYear}.";
        }
    }
}
