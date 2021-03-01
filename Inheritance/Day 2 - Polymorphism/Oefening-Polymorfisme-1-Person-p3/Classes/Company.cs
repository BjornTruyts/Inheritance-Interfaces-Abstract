using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_1_Person_p3.Classes
{
    class Company
    {
        Person[] _people;

        public Company()
        {
            _people = new Person[2];
            _people[0] = new Employer();
            _people[1] = new Employee();
        }

        public void PrintAllTasks()
        {
            foreach (Person person in _people)
            {
                person.WhatIsMyTask();
            }
        }
    }
}
