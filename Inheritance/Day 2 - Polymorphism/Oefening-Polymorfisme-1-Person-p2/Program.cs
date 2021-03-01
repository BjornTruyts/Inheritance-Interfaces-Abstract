using Oefening_Polymorfisme_1_Person_p2.Classes;
using System;

namespace Oefening_Polymorfisme_1_Person_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person employer = new Employer();
            Person employee = new Employee();

            person.WhatIsMyTask();
            employer.WhatIsMyTask();
            employee.WhatIsMyTask();


            Console.ReadLine();
        }
    }
}
