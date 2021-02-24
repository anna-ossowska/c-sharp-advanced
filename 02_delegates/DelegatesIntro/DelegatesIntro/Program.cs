using System;

namespace DelegatesIntro
{
    public delegate void MeDelegate();
    // class MeDelagate { }

    class Program
    {
        static void Main(string[] args)
        {
            // same as: MeDelegate del = new MeDelegate(Foo);
            MeDelegate del = Foo;

            InvokeTheDelegate(Foo);
        }

        static void InvokeTheDelegate(MeDelegate deleg)
        {
            // same as: deleg.Invoke();
            deleg();
        }

        static void Foo()
        {
            Console.WriteLine("Foo()");
        }
    }
}
