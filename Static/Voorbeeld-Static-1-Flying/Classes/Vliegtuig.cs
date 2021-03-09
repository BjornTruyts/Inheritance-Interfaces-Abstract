using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Static_1_Flying.Classes
{
    public class Vliegtuig
    {
        public int BrandstofNiveau { get; set; }
        public int MaximumBrandstofNiveau { get; set; }

        public Vliegtuig(int maximumBrandstofNiveau)
        {
            MaximumBrandstofNiveau = maximumBrandstofNiveau;
        }
    }
}
