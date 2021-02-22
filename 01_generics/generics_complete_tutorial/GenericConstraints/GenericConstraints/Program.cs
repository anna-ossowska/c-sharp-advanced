using System;
using System.Collections;

namespace GenericConstraints
{
    class ClassOne { public ClassOne() { } }
    class ClassTwo { public ClassTwo(int i, char c) { } }
    class ClassThree : ClassOne { public ClassThree() { } }

    class Program
    {
        static void Main(string[] args)
        {
            static T ProduceA<T>() where T : ClassOne, new()
            {
                T returnVal = new T();
                return returnVal;
            }

            // <T> can only be a class (reference type) and must have a default parameterless constructor
            ProduceA<ClassOne>();

            // won't compile as ClassTwo does not iherit from ClassOne and has a default constructor with two parameters
            // ProduceA<classTwo>();

            // will compile as ClassThree iherits from ClassOne and has a default parameterless constructor
            ProduceA<ClassThree>();
        }
    }
}
