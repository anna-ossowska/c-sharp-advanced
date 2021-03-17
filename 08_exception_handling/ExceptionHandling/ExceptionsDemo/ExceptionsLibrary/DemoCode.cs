using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            int output = 0;

            Console.WriteLine("Open data base connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                // throw vs throw ex:

                // 'throw' is the proper way of putting the exception back into bubble up process.
                // It gives the complete original StackTrace information.

                // Throwing the exception object again ('throw ex')
                // rewrites the Stack and gives us the wrong information.

                // Creating a new exception without loosing the original StackTrace information
                throw new ArgumentException("You passed in bad data", ex);
            }
            // This block will always be executed no matter whether an exception raised or not
            finally
            {
                Console.WriteLine("Close data base connection.");
            }

            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

       public int GetNumber(int position)
       {
            int output = 0;

            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];

            return output;
       }
    }
}
