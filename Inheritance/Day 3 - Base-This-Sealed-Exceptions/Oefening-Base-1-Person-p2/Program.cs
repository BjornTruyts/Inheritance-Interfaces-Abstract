using Oefening_Base_1_Person_p2.Classes;
using System;

namespace Oefening_Base_1_Person_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            teacher.WhoAmI();
            teacher.IGoTo();
            Console.WriteLine("-----------------");
            student.WhoAmI();
            student.IGoTo();


            Console.ReadLine();
        }
    }
}
