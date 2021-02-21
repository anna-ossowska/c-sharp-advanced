using System;

namespace GenericTypeInstantiation
{
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
            // Value is not overwritten, because we get three different data types
            MyClass<string>.Value = 10;
            MyClass<int>.Value = 20;
            MyClass<Program>.Value = 33;

            Console.WriteLine(MyClass<string>.Value);
        }
    }
}
