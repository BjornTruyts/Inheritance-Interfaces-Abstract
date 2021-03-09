using System;
using System.Collections.Generic;
using System.Text;
using Voorbeeld_Static_2_Calculate.Classes;

namespace Voorbeeld_Static_2_Calculate.Extensions
{
    public static class BerekeningExtensions
    {
        public static void VoegToeAanResultaat(this Berekening huidigeWaarde, int toegevoegdewaarde)
        {
            huidigeWaarde.Resultaat += toegevoegdewaarde;
        }
    }
}
