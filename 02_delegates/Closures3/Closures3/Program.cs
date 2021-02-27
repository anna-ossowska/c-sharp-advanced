using System;

namespace Closures3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> x = GetFunc();
            Console.WriteLine(x(5));
            Console.WriteLine(x(6));
        }

        public static Func<int, int> GetFunc()
        {
            int i = 0;

            Func<int, int> ret = (myValue) =>
            {
                i++;
                return myValue + i;
            };
            return ret;
        }
    }
}
