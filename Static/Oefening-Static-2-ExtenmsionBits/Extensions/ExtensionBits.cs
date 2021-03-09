using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Static_2_ExtenmsionBits.Extensions
{
    public static class ExtensionBits
    {
        public static bool IsGreaterThan(this int number, int compareValue)
        {
            return number > compareValue;
        }

        public static string AddString(this string str, string stringToAdd)
        {
            return str + stringToAdd;
        }

        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
