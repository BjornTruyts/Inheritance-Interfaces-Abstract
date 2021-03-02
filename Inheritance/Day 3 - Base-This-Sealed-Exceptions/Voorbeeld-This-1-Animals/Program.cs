using System;
using Voorbeeld_This_1_Animals.Classes;

namespace Voorbeeld_This_1_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Mus mus = new Mus();
            mus.MaakGeluid();

            Mus mus2 = new Mus("kwaak");
            mus2.MaakGeluid();

            Console.ReadLine();
        }
    }
}
