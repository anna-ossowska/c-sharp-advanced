using System;

namespace Closures5
{
    // How the compiler implements more complex closures:
    class Program
    {
        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            b();
            a();
            a();
            b();
        }

        class DisplayClass
        {
            int i = 5;

            public void Nameless1()
            {
                i++;
            }

            public void Nameless2()
            {
                i += 2;
            }
        }

        static Action GiveMeAction()
        {
            //Action ret = null;
            //int i = 5;
            //ret += () => i++;
            //ret += () => i += 2;
            // return ret;

            Action ret = null;
            var temp = new DisplayClass();
  
            ret += temp.Nameless1;
            ret += temp.Nameless2;

            return ret;
        }
    }
}
