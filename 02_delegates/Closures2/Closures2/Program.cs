using System;

namespace Closures2
{
    class Program
    {
        static void Main()
        {
            Action a = GiveMeAction();
            a();
            a();
            a();
        }

       static Action GiveMeAction()
        {
            Action ret = null;
            int i = 0;
            ret += () =>
            {
                Console.WriteLine("First method: " + i++);
            };

            ret += () =>
            {
                Console.WriteLine("Second method: " + i++);
            };
            return ret; // returning the chain of delegates
        }
    }
}
