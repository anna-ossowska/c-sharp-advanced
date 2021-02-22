using System;

namespace GenericTypeInference
{
    class RandomClass<T>
    {
        public RandomClass(T arg) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            static void P<T>(T item)
            {
                Console.WriteLine(item);
            }

            // Inference works with generic methods
            // Same as: P<int>(5);
            P(5);

            // Inference does NOT work with generic classes
            RandomClass<int> random = new RandomClass<int>(5);
        }
    }
}
