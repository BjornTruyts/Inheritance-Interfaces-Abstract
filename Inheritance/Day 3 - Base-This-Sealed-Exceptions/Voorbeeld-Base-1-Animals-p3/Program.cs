using System;
using Voorbeeld_Base_1_Animals_p3.Classes;

namespace Voorbeeld_Base_1_Animals_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo[1] = new Dier();
            Dier dier = zoo[3];
            //Dier dier = zoo.dieren[3];


            Console.ReadLine();
        }
    }
}
