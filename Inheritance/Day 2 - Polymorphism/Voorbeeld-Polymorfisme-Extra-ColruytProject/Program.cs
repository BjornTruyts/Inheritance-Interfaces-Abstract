using ColruytProject.Classes;
using System;

namespace ColruytProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Colruyt colruyt = new Colruyt();

            colruyt.ScanProducten();


            Console.ReadLine();
        }
    }
}
