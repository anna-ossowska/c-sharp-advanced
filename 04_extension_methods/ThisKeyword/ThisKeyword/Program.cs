using System;

namespace ThisKeyword
{
    // 'this' keyword and instance methods under the hood:
    // In their roots instance methods are static

    static class DataMethods
    {
        public static void Increment(this Num _this)
        {
            _this.numIncrement++;
            Console.WriteLine("Incrementing: " + _this.numIncrement);
        }
    }

    public class Num
    {
        public int numIncrement;
    }

    class Program
    {
        static void Main()
        {
            Num n1 = new Num();
            Num n2 = new Num();

            n1.Increment();
            n1.Increment();

            n2.Increment();
        }
    }
}
