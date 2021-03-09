using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Static_1_Flying_2
{
    public class Vliegtuig
    {
        public decimal SnelheidInKm { get; set; }
        public decimal HoogteInKm { get; set; }

        public decimal SnelheidInMijlen { get; set; }

        public decimal HoogteInMijlen { 
            get 
            { 
                return ConverteerNaarMijl(HoogteInMijlen);
            } 
        }

        private static decimal ConverteerNaarMijl(decimal afstandInKm)
        {
            return afstandInKm * 1.5M;
        }
    }
}
