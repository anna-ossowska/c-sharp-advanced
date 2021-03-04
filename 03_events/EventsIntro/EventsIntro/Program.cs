using System;

namespace EventsIntro
{
    class Newsletter
    {
        public event Action Subscribing;

        public void ClickSubscribe()
        {
            Subscribing?.Invoke();
            Console.WriteLine("You have subscribed to the newsletter.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Newsletter n = new Newsletter();
            n.Subscribing += () => Console.WriteLine("Clicking");
            n.ClickSubscribe();
        }
    }
}
