using System;
using Voorbeeld_Exceptions_1_Calculator.Classes;

namespace Voorbeeld_Exceptions_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();

                calculator.Divide(50, 0);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got a Program exception: " + exception);
                //throw exception; If we want the code to continue working even after an Exception, we comment this out.
            }

            Console.WriteLine("We finished!");
            Console.ReadLine();
        }
    }
}
