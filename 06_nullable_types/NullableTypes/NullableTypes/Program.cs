using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            DateTime? date = null;
            int? num = null;

            // Throws an exception 
            // Console.WriteLine(date.Value);

            // The preferred way of getting the value, which does not throw an Exception if null:
            Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}");

            Console.WriteLine($"HasValue: {date.HasValue}");

            DateTime? date1 = new DateTime(1999, 2, 1);

            // Cannot implicitly convert type 'System.DateTime?' to 'System.DateTime'
            // DateTime date2 = date1;

            // Preventing an Exception
            DateTime date2 = date1.GetValueOrDefault();
            Console.WriteLine(date2);

            // Value type can be easily converted into a Nullable type
            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());

            // Null-coalescing operator
            DateTime? date4 = null;
            DateTime date5 = date4 ?? DateTime.Today;

            // Same as:
            // DateTime date5 = (date4 != null) ? date4.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date5);
        }
    }
}
