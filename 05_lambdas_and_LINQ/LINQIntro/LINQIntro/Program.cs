using System;
using System.Linq;

namespace LINQIntro
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new[] { 2, 3, 4, 1, 6, 9, 5, 7 };

            // Query syntax:
            var result1 =
                from n in numbers
                where n < 5
                select n;


            // Fluent syntax:
            var result2 =
                numbers
                .Where(n => n > 5)
                .Select(n => n);


            foreach (int i in result1)
                Console.WriteLine(i);


            foreach (int i in result2)
                Console.WriteLine(i);
        }
    }
}
