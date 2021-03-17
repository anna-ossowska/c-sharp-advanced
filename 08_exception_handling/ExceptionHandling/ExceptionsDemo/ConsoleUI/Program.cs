using System;
using ExceptionsLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            DemoCode demo = new DemoCode();

            try
            {
                int result = demo.GrandParentMethod(4);
                Console.WriteLine($"The value at the given position is: {result}");
            }
            catch (Exception ex)
            {
                // Using ex to get more information about the Exception itself
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }

            Console.ReadLine();
        }
    }
}

