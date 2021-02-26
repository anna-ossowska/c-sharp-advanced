using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda:
            Func<int, bool> func = i => i > 5;
            Console.WriteLine(func(3));
            Console.WriteLine(func(7));

            // Lambda under the hood:
            //static bool MethodName(int i)
            //{
            //    return i > 5;
            //}

            // Anonymous method (rarely used):
            Func<int, bool> func2 = delegate(int i) { return i > 5; };
            Console.WriteLine(func2(3));
            Console.WriteLine(func2(7));
        }
    }
}
