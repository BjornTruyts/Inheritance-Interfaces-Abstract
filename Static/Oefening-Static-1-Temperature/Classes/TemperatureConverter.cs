using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_Static_1_Temperature.Classes
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double temperatureCelsius)
        {
            return (temperatureCelsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) * 5 / 9;
        }
    }
}
