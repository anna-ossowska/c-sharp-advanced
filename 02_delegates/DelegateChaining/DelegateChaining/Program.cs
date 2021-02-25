using System;

namespace DelegateChaining
{
    class Program
    {
        delegate void MeDelegate();

        static void Main(string[] args)
        {
            MeDelegate d = Foo;
            // += and -= is the syntactic sugar
            // This is what's going on under the hood:
            // d = (MeDelegate)Delegate.Combine(d, new MeDelegate(Goo));
            // Used mostly for events and the Observer Pattern
            d += Goo;
            d += Sue;
            d += Foo;
            d -= Foo;

            foreach(MeDelegate m in d.GetInvocationList())
            {
                Console.WriteLine(m.Target + ": " + m.Method);
            }
        }

        static void Foo() { Console.WriteLine("Foo()"); }
        static void Goo() { Console.WriteLine("Goo()"); }
        static void Sue() { Console.WriteLine("Sue()"); }
    }
}
