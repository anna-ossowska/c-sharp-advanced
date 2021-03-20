using System;

namespace ExtensionMethodsSummary
{
    class Program
    {
        static void Main()
        {
            string post = "This is supposed to be a very long post.";

            Console.WriteLine(post.Shorten(5));
            Console.WriteLine(post.Shorten(2));
        }
    }
}
