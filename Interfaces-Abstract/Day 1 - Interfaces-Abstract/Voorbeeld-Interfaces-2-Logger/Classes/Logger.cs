using System;
using System.Collections.Generic;
using System.Text;
using Voorbeeld_Interfaces_2_Logger.Interfaces;

namespace Voorbeeld_Interfaces_2_Logger.Classes
{
    public class Logger : IConsole, IPrinter
    {
        public void Print(string tekst)
        {
            Console.WriteLine(tekst);
        }
    }
}
