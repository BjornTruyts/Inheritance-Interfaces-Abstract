using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_This_1_Animals.Classes
{
    public class Dier
    {
        private string _geluid;

        public Dier(string geluid)
        {
            _geluid = geluid;
        }

        public void MaakGeluid()
        {
            Console.WriteLine(_geluid);
        }
    }
}
