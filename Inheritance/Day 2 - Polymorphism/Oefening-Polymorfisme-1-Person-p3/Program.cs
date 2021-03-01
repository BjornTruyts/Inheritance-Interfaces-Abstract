using Oefening_Polymorfisme_1_Person_p3.Classes;
using System;

namespace Oefening_Polymorfisme_1_Person_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            company.PrintAllTasks();

            Employee employee = new Employee();
            Person person = employee;
            Employer employer = (Employer)person;


            Console.ReadLine();
        }
    }
}
