using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Exceptions_1_Calculator.Classes
{
    public class Calculator
    {
        public void Divide(int number1, int number2)
        {
            double value = 0;

            try
            {
                value = number1 / number2;
            }
            catch (DivideByZeroException exception)
            {
                //Console.WriteLine("Cannot divide by zero!");

                Console.WriteLine(exception.Message); // Possible message to show to the users.
                Console.WriteLine(exception); // This should not be shown to the user, instead it should be logged somewhere.
                throw exception;
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine("Calculation error");
            }
            catch (SystemException exception)
            {
                Console.WriteLine("System error");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got a Calculator exception.");
                throw exception;
            }
            finally
            {
                Console.WriteLine("Code in the 'finally' will always run, even if there is an Exception.");
            }

            Console.WriteLine("Divided value: " + value);
        }
    }
}
