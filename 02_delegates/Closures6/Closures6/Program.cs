using System;

namespace Closures6
{
    // How the compiler implements more complex closures:
    class Program
    {
        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            a();
            a();
            b();
        }

        class DisplayClass
        {
            int i = 0;
            int j = 5;

            public void Nameless1()
            {
                i++;
            }

            public void Nameless2()
            {
                j++;
            }

            public void Nameless3()
            {
                i++;
                j++;
            }
        }

        static Action GiveMeAction()
        {
            //Action ret = null;
            //int i = 0;
            //int j = 5;
            //ret += () => i++;
            //ret += () => j++;
            //ret += () => { i++; j++ };
            // return ret;

            Action ret = null;
            var temp = new DisplayClass();

            ret += temp.Nameless1;
            ret += temp.Nameless2;
            ret += temp.Nameless3;

            return ret;

        }
    }
}
