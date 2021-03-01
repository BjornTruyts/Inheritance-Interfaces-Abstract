using Oefening_Inheritance.Classes;
using System;

namespace Oefening_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer boss = new Employer("John");
            Employee worker = new Employee("Bob");

            boss.Employees.Add(worker);
            worker.Boss = boss;

            boss.GiveTask(worker);
            worker.Work();

            Console.WriteLine("-----------------");

            boss.WhatIsMyTask();
            worker.WhatIsMyTask();


            Console.ReadLine();
        }
    }
}
