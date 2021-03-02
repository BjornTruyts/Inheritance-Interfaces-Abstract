using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Polymorfisme_4_Computershop.Classes
{
    public class Computershop
    {
        Hardware[] _hardwareArray;
        //List<Hardware> _hardwareList; // Much easier to work with than Arrays, but this will be shown in a later course.

        public Computershop()
        {
            _hardwareArray = new Hardware[50];
            //_hardwareList = new List<Hardware>(); // Much easier to work with than Arrays, but this will be shown in a later course.
        }

        public void AddHardware(Hardware hardware)
        {
            for (int i = 0; i < _hardwareArray.Length; i++)
            {
                if (_hardwareArray[i] == null)
                {
                    _hardwareArray[i] = hardware;
                    break;
                }
            }

            //_hardwareList.Add(hardware); // Much easier to work with than Arrays, but this will be shown in a later course.
        }

        public Laptop[] GetAllLaptops() //This is one way to get back a list of Laptops.
        {
            List<Laptop> laptops = new List<Laptop>();

            foreach (Hardware hardware in _hardwareArray)
            {
                if(hardware is Laptop)
                {
                    Laptop temporaryLaptop = (Laptop)hardware;
                    laptops.Add(temporaryLaptop);
                }
            }

            return laptops.ToArray();
        }

        public void GetAllDesktops() //This way we just print the Desktops, which was also a valid way to do the excercise.
        {
            foreach (Hardware hardware in _hardwareArray)
            {
                if (hardware is Desktop)
                {
                    hardware.PrintDetails();
                }
            }
        }

        public void GetAllServers()
        {
            foreach (Hardware hardware in _hardwareArray)
            {
                if (hardware is Server)
                {
                    hardware.PrintDetails();
                }
            }
        }
    }
}
