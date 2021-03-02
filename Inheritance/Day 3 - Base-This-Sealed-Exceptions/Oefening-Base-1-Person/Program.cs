using Oefening_Base_1_Person.Classes;
using System;

namespace Oefening_Base_1_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            teacher.IGoTo();
            Console.WriteLine("-----------------");
            student.IGoTo();


            Console.ReadLine();
        }
    }
}
