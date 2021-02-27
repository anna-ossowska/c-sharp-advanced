using System;

namespace Closures
{
    class Program
    {
        static void Main()
        {
            Action a = GiveMeAction();
            a(); a(); a();
        }

        static Action GiveMeAction()
        {
            int i = 0;
            return () => i++; // Closing/capturing the scope of i
        }
    }
}
