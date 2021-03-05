using System;
using System.Collections.Generic;
using System.Text;
using Voorbeeld_Interfaces_2_Logger.Interfaces;

namespace Voorbeeld_Interfaces_2_Logger.Classes
{
    public class Logger : IConsole, IPrinter
    {
        void IConsole.Print(string tekst)
        {
            Console.WriteLine("Console print: " + tekst);
        }
        void IPrinter.Print(string tekst)
        {
            Console.WriteLine("Printer print: " + tekst);
        }
    }
}
