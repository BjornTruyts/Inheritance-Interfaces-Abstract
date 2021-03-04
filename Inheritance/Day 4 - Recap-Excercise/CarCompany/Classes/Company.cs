using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public class Company
    {
        public string CompanyName { get; set; }
        public List<Car> Cars { get; set; }

        public Company()
        {
            Cars = new List<Car>();

            Cars.Add(new GasCar("Ford", "Fiesta", 2013));
            Cars.Add(new HybridCar("Toyota", "Prius", 2019));
            Cars.Add(new ElectricCar("Tesla", "Model 3", 2020));
        }

        public Company(string companyName) : this()
        {
            CompanyName = companyName;
        }
    }
}
