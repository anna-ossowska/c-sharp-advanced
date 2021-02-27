using System;

namespace Closures4
{
    // How the compiler implements closures:
    // C# compiler detects when a delegate forms a closure which is passed out of the current scope,
    // and it promotes the delegate and the associated local variables into a compiler generated class.
    // Each time we invoke the delegate we are actually calling the method on this class.
    // Once we are no longer holding a reference to this delegate, the class can be garbage collected.

    // Simple simulation:

    class DisplayClass
    {
        public int i;
        public void MethodGeneratedFromLambda()
        {
            i++;
        }
    }

    class Program
    {
        static void Main()
        {
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            a(); // 1
            a(); // 2
            b(); // 1
        }

        static Action GiveMeAction()
        {
            return new Action(new DisplayClass().MethodGeneratedFromLambda);
        }
    }
}
