using System;

namespace GenericConstraintsInUse
{
    class Program
    {
        static void Main(string[] args)
        {
            static void TakeA<T>(T arg) where T : IComparable
            {
            }

            static void TakeB(IComparable arg)
            {
            }

            // No boxing takes place if T is a value type
            TakeA(5);

            // Boxing takes place if T is a value type
            TakeB(4);
        }
    }
}
