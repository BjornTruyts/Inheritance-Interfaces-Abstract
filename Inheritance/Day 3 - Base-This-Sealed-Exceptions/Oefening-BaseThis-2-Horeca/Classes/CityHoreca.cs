using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_BaseThis_2_Horeca.Classes
{
    public class CityHoreca
    {
        private List<Horeca> _horecaList;

        public Horeca this[int index]
        {
            get { return _horecaList[index]; }
            set 
            {
                if (_horecaList.Count > index)
                {
                    _horecaList[index] = value;
                }
                else
                {
                    Console.WriteLine($"Can't modify value, our list only consists of {_horecaList.Count} items");
                }
            }
        }

        public CityHoreca()
        {
            _horecaList = new List<Horeca>();
        }

        public void AddHoreca(Horeca horeca)
        {
            _horecaList.Add(horeca);
        }

        public void SearchByName(string name)
        {
            foreach (Horeca horeca in _horecaList)
            {
                if(string.Equals(horeca.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address: " + horeca.Address);

                    return;
                }
            }

            Console.WriteLine("Nothing found!");
        }
    }
}
