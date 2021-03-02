using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_This_2_Taxes.Classes
{
    class Employee
    {
        public int Salary { get; set; }

        public Employee()
        {
            Salary = 50;
        }

        public void PrintEmployee()
        {
            Tax.CalcTax(this); //Give the current instance of Employee as parameter.
        }
    }
}
