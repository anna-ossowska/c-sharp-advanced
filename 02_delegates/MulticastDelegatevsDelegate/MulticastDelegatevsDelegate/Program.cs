using System;
using System.Collections.Generic;

namespace MulticastDelegatevsDelegate
{
    class Program
    {
        delegate int MeDelegate();

        static void Main(string[] args)
        {
            // Inheritance chain:
            // Delegate -> MulticastDelegate -> MeDelegate
            MeDelegate d = ReturnFive;
            d += ReturnTen;
            d += ReturnTwelve;

            foreach (int i in GetAllReturnValues(d))
            {
                Console.WriteLine(i);
         
            }
        }

        static List<int> GetAllReturnValues(MeDelegate d)
        {
            List<int> ints = new List<int>();

            foreach (MeDelegate del in d.GetInvocationList())
            {
                ints.Add(del());
            }
            return ints;
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int ReturnTwelve() { return 12; }
    }
}
