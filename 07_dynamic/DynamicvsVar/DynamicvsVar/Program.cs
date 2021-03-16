using System;

namespace DynamicvsVar
{
    class Program
    {
        static void Main()
        {
            // Imlicitly typed variables must be initialized
            // Thus, this line throws a compile time error:
            // var testVar;

            var testVar = 1;

            // Under the hood dynamic is just an object and it is flexible,
            // which means we can freely and implicitly change its type
            dynamic testDynamic;
            testDynamic = 1;
            testDynamic = "test";
            testDynamic += 100;
            Console.WriteLine(testDynamic);

            var personVar = new Person();
            dynamic personDynamic = new Person();

            // Compile time error, no definition for 'Age'
            personVar.Age = "John";

            // Runtime error, no definition for 'Age'
            personDynamic.Age = 13;

            // Compile time error, personVar is already set as a Person type, implicit conversion is not possible
            personVar = 1;

            // No error, flexible conversion from Person type to int
            personDynamic = 1;
        }

        // Return type of the method cannot be var because we need to know the return type specifically
        // dynamic can be used, as under the hood it's just an object
        static dynamic GetMessage()
        {
            return "This is a test";
        }
    }
}
