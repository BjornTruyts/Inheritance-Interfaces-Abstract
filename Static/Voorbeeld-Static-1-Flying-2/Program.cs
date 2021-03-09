using System;

namespace Voorbeeld_Static_1_Flying_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vliegtuig boeing = new Vliegtuig();
            Vliegtuig airbus = new Vliegtuig();
            Vliegtuig privateJet = new Vliegtuig();
            //Normally this would mean 3 methods ConverteerNaarMijl() would exist, but due to static only one ever exists in memory. More performance!

            Console.WriteLine("Hello World!");
        }
    }
}
