using System;
using System.IO;

namespace UsingStatement
{
    class Program
    {
        static void Main()
        {
            try
            // With the 'using' statement compiler creates 'finally' block under the hood,
            // which calls the Dispose() method on streamReader object
            {
                using (var streamReader = new StreamReader(@"c:\summary.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occured.");
            }
        }
    }
}
