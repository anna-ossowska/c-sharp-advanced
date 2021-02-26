using System;
using System.Collections.Generic;

namespace FuncAndAction
{
    class Program
    {
        delegate T MeDelegate<T>();

        static void Main(string[] args)
        {
            Func<int> d = ReturnFive;
            d += ReturnTen;
            d += ReturnTwelve;

            // Func is a generic delegate that returns sth
            Func<int, bool> f1 = TakeIntAndReturnBool;
            Func<int, string, bool> f2 = TakeIntAndStringAndReturnBool;

            // Action does not return anything
            Action<string> a = TakeStringAndReturnVoid;

            foreach (int i in GetAllReturnValues(d))
            {
                Console.WriteLine(i);

            }
        }

        static IEnumerable<TArg> GetAllReturnValues<TArg>(Func<TArg> d)
        {
            foreach (Func<TArg> del in d.GetInvocationList())
            {
                yield return del();
            }
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int ReturnTwelve() { return 12; }

        static bool TakeIntAndReturnBool(int i) { return false; }
        static bool TakeIntAndStringAndReturnBool(int i, string s) { return true; }
        static void TakeStringAndReturnVoid(string s) { }
    }
}
