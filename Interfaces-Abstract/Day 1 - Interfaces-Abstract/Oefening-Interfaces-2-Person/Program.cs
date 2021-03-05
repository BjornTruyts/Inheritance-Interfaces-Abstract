using Oefening_Interfaces_2_Person.Classes;
using Oefening_Interfaces_2_Person.Interfaces;
using System;
using System.Collections.Generic;

namespace Oefening_Interfaces_2_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IConsoleWriteable> consoleWriteableList = new List<IConsoleWriteable>();

            Teacher teacher = new Teacher("Mark", 35);
            Student student = new Student("Bob", 25);

            //Person person = new Person("Mike", 30); //This person can't be added to the list, as the class Person does not implement IConsoleWriteable.

            consoleWriteableList.Add(teacher);
            consoleWriteableList.Add(student);

            foreach (var item in consoleWriteableList)
            {
                item.ToConsoleString();

                if(item is ITeach)
                {
                    (item as ITeach).Teach();
                }

                if (item is ILearn)
                {
                    (item as ILearn).Learn();
                }
            }

            Console.ReadLine();
        }
    }
}
