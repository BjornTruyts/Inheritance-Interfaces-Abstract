using Oefening_Polymorfisme_4_Computershop.Classes;
using System;

namespace Oefening_Polymorfisme_4_Computershop
{
    class Program
    {
        static void Main(string[] args)
        {
            Computershop computershop = new Computershop();

            Laptop dell = new Laptop("Dell", 1100);
            Laptop macbook = new Laptop("Macbook Air", 1300);

            Desktop alienware = new Desktop("Alienware", 2000);
            Desktop Macintoch = new Desktop("iMac", 1500);

            Server ibm = new Server("IBM", 9000);
            Server cisco = new Server("Cisco", 7500);

            computershop.AddHardware(dell);
            computershop.AddHardware(macbook);
            computershop.AddHardware(alienware);
            computershop.AddHardware(Macintoch);
            computershop.AddHardware(ibm);
            computershop.AddHardware(cisco);

            Console.WriteLine("----|Laptops|----");
            Laptop[] laptops = computershop.GetAllLaptops();

            foreach (var laptop in laptops)
            {
                laptop.PrintDetails();
            }

            Console.WriteLine("----|Desktops|----");
            computershop.GetAllDesktops();

            Console.WriteLine("----|Servers|----");
            computershop.GetAllServers();


            Console.ReadLine();
        }
    }
}
