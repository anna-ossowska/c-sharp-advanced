using System;

namespace MethodAndTarget
{
    public class MyClass
    {
        public static void Foo(int num1) { }

        public void Goo(int num2) { }
    }

    delegate void MeDelegate(int value);

    class Program
    {
        static void Main(string[] args)
        {
            // Delegate keeps track of two Properties:
            // Method: gets the method represented by the delegate
            // Target: gets the class instance on which the current delegate invokes the instance method
            
            MeDelegate deleg1 = MyClass.Foo;
            Console.WriteLine(deleg1.Method);
            Console.WriteLine(deleg1.Target); // returns nothing because Foo is a static method


            MyClass m = new MyClass();
            MeDelegate deleg2 = m.Goo;
            Console.WriteLine(deleg2.Method);
            Console.WriteLine(deleg2.Target);

        }
    }
}
