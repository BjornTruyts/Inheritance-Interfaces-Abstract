using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Static_1_Flying.Classes
{
    public static class TankTools
    {
        public static void TankVol(Vliegtuig vliegtuig)
        {
            while (vliegtuig.BrandstofNiveau < vliegtuig.MaximumBrandstofNiveau)
            {
                vliegtuig.BrandstofNiveau++;
            }
        }
    }
}
