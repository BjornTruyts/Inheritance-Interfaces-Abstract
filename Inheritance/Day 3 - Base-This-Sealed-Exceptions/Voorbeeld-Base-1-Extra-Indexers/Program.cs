using System;
using Voorbeeld_Base_1_Extra_Indexers.Classes;

namespace Voorbeeld_Base_1_Extra_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();

            float temp1 = tempRecord[5]; //Simplified syntax + purpose more intuitive.
            float temp2 = tempRecord.temps[1]; //Weird to read, as we already know tempRecord has temperatures.

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);

            Console.ReadLine();
        }
    }
}
