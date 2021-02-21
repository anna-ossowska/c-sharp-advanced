using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Pair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public override string ToString()
        {
            return "{ " + First + ", " + Second + " }";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> p = new Pair<int, int> { First = 5, Second = 3 };
            Pair<string, string> people1 = new Pair<string, string> { First = "Marry", Second = "John" };
            Pair<string, string> people2 = new Pair<string, string> { First = "Samantha", Second = "Bob" };
            Console.WriteLine(people1.ToString());
        }

    }
}
