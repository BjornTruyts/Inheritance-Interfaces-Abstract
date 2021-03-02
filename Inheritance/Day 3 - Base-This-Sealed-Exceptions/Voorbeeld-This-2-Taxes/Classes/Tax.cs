using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_This_2_Taxes.Classes
{
    class Tax
    {
        public static void CalcTax(Employee employee) //Ignore the STATIC modifier for now, we'll get to this later. Just know that this makes the Tax.CalcTax() method available everywhere.
        {
            Console.WriteLine(0.3 * employee.Salary);
        }
    }
}
