using System;
using System.Collections.Generic;

namespace GenericsAndCodeBloat
{
    class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public override string ToString()
        {
            return "{ " + First + ", " + Second + " }";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pair<int> p = new Pair<int> { First = 5, Second = 3 };
            Pair<string> people1 = new Pair<string> { First = "Marry", Second = "John" };
            Pair<string> people2 = new Pair<string> { First = "Samantha", Second = "Bob" };
            Console.WriteLine(people1.ToString());

            Console.WriteLine(p.GetType().Equals(people1.GetType()));
            Console.WriteLine(p.GetType());
            Console.WriteLine(people1.GetType());
        }
    }
}
