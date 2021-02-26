using System;

namespace DelegateChainsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action deleg = (Action)Foo + MyException + Goo + Foo;
            foreach (Action a in deleg.GetInvocationList())
            {
                try
                {
                    a();
                }
                catch
                {
                    Console.WriteLine("Exception");
                }
            }
        }

        static void Foo() { Console.WriteLine("Foo()"); }
        static void MyException() { throw new Exception(); }
        static void Goo() { Console.WriteLine("Goo()"); }
    }
}
