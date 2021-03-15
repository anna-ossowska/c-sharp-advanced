using System;

namespace Intro
{
    // Reconstructing the Nullable<T> struct:

    struct CustomNullable<T> where T : struct
    {
        public T value;
        public bool hasValue;

        public CustomNullable(T value)
        {
            this.value = value;
            hasValue = true;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            // value is 0, hasValue is false, so we get null
            CustomNullable<int> num1 = new CustomNullable<int>();

            CustomNullable<int> num2 = new CustomNullable<int>(5);
            Console.WriteLine(num2);

            // Regular syntax:
            int? num3 = 5;

            // Regular syntax under the hood:
            Nullable<int> num4 = new Nullable<int>(5);          
        }
    }
}
