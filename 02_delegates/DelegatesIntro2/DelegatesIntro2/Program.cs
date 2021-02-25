using System;
using System.Collections.Generic;

namespace DelegatesIntro2
{
    class Program
    {
        delegate bool MeDelegate(int n);
        public static bool GreaterThanThree(int n) { return n > 3; }
        public static bool LessThanFive(int n) { return n < 5; }

        static void Main(string[] args)
        {
            int[] numbers = new[] { 9, 1, 2, 3, 8, 4, 5 };
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, GreaterThanThree);
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
