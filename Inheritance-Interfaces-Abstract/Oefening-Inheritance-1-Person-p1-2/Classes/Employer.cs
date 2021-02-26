using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Inheritance.Classes
{
    public class Employer : Person
    {
        public List<Employee> Employees { get; set; }

        public Employer(string givenName)
        {
            GivenName = givenName;
            Employees = new List<Employee>();
        }

        public void GiveTask(Employee employee)
        {
            Console.WriteLine($"{GivenName}: {employee.GivenName} please do this task for me.");
        }
    }
}
