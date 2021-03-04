using System;

namespace EventsIntroWithComments
{
    class Newsletter
    {
        // Three important concepts about events:
        // 1. Internally the event stores the "list" of pointers to the methods to call when an event is raised.
        //    But to call these methods we must know what arguments to pass.
        // 2. We use a Delegate as a "Contract" between the event and all the methods that subscribe to the event.
        // 3. Delegate provides us with the method signatures, thus we know how to call the specific methods (subscribers).

        // This event can cause any method which conforms to Action to be called.
        // Action points to methods which return void and take no arguments.
        public event Action Subscribing;

        // Here comes the code I want to be executed when the Subscribing event fires.
        public void ClickSubscribe()
        {
            // I make sure I have any subscribers before invoking
            Subscribing?.Invoke();
            // Same as:
            //if (Subscribing!= null)
            //{
            //    Subscribing();
            //}

            Console.WriteLine("You have subscribed to the newsletter.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Newsletter n = new Newsletter();

            // Subscribe to the event
            n.Subscribing += () => Console.WriteLine("Clicking");

            // Raise the event within a method
            n.ClickSubscribe();
        }
    }
}
