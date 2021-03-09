using Oefening_Static_1_Temperature.Classes;
using System;

namespace Oefening_Static_1_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the conversion you wish to do.");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. from Fahrenheit to Celsius.");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.Write("Please enter the Celsius temperature: ");
                string value = Console.ReadLine();
                bool success = double.TryParse(value, out double celsius); //Could build in some safety for non-numeric values, but that's not the point of this example.
                Console.WriteLine("Temperature in Fahrenheit: " + TemperatureConverter.CelsiusToFahrenheit(celsius));
            }
            else if (choice == "2")
            {
                Console.Write("Please enter the Fahrenheit temperature: ");
                string value = Console.ReadLine();
                bool success = double.TryParse(value, out double fahrenheit);
                Console.WriteLine("Temperature in Celsius: " + TemperatureConverter.FahrenheitToCelsius(fahrenheit));
            }
            else
            {
                Console.WriteLine("Invalid input, bye.");
            }


            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
