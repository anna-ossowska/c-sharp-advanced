using System;

namespace ExceptionHandlingSummary
{
    class Program
    {
        static void Main()
        {
            // Global Exception Handling block
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            // Exceptions go from more to less specific
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException)
            {

            }
            catch (Exception)
            {
                Console.WriteLine("A unexpected error.");
            }
        }
    }
}
