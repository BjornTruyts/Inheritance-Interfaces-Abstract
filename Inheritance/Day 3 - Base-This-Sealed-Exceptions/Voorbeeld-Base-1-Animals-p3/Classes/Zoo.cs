using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Base_1_Animals_p3.Classes
{
    public class Zoo
    {
        //public Dier[] Dieren { get; set; }
        private Dier[] _dieren = new Dier[100];

        public Dier this[int index]
        {
            get { return _dieren[index]; }
            set { _dieren[index] = value; }
        }

    }
}
