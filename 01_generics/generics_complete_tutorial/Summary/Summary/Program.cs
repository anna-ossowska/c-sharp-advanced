using System;

namespace Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            

            // Nullable class is actually a part of .NET Framework:
            Nullable<int> i = new Nullable<int>(5);
            Console.WriteLine(i.HasValue); // True

            // Assigning value type to null
            Nullable<int> j = new Nullable<int>();
            Console.WriteLine(j.HasValue); // False

            // Assigning value type to null (shortcut):
            int? k = null;
            Console.WriteLine(k.HasValue); // False
        }
    }
}
