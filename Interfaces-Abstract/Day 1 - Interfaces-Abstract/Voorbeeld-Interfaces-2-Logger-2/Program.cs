using System;
using Voorbeeld_Interfaces_2_Logger.Classes;
using Voorbeeld_Interfaces_2_Logger.Interfaces;

namespace Voorbeeld_Interfaces_2_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole consoleLogger = new Logger();

            consoleLogger.Print("Mijn log.");

            IPrinter printerLogger = new Logger();

            printerLogger.Print("Mijn log.");


            Console.ReadLine();
        }
    }
}
