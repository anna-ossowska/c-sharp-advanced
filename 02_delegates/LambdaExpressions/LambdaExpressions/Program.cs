using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        delegate bool MeDelegate(int n);

        static void Main(string[] args)
        {
            int[] numbers = new[] { 9, 1, 2, 3, 8, 4, 5 };
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, n => n > 3);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }

        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int number in numbers)
            {
                if (gauntlet(number))
                {
                    yield return number;
                }
            }
        }
    }
}
