using System;

namespace OpenClosedTypes
{
    // Open type is a type that takes a generic argument
    class MyClass<T>
    {
        public static int Value;

        static MyClass()
        {
            Console.WriteLine(typeof(MyClass<T>));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Closed type, T is now a string
            MyClass<string>.Value = 20;
        }
    }
}
