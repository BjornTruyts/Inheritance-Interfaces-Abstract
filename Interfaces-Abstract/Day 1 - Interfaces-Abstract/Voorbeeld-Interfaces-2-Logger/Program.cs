using System;
using Voorbeeld_Interfaces_2_Logger.Classes;

namespace Voorbeeld_Interfaces_2_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Print("Mijn log.");


            Console.ReadLine();
        }
    }
}
