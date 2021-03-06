using System;

namespace ExtensionMethodsIntro
{
    // Extension method is a static method of a static class, where 'this' keyword is applied to the first parameter

    static class ExtensionHelpers
    {
        public static DateTime Combine(this DateTime datePart, DateTime timePart)
        {
            return new DateTime(datePart.Year, datePart.Month, datePart.Day, timePart.Hour, timePart.Minute, timePart.Second);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("1/5/2025");
            DateTime time = DateTime.Parse("1/2/1998 9:55");

            // Static method call
            DateTime combined1 = ExtensionHelpers.Combine(date, time);

            // Extension method call
            DateTime combined2 = date.Combine(time);

            Console.WriteLine(combined1);
            Console.WriteLine(combined2);
        }
    }
}
