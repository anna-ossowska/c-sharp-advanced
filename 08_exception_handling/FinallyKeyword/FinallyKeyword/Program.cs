using System;
using System.IO;

namespace FinallyKeyword
{
    class Program
    {
        static void Main()
        {
            StreamReader streamReader = null;
            
            try
            {
                streamReader = new StreamReader(@"c:\summary.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error");
            }
            // streamReader is not managed by CLR, so there is no Garbage Collection applied to it
            // Performing the manual cleanup:
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Dispose();
                } 
            }
        }
    }
}
