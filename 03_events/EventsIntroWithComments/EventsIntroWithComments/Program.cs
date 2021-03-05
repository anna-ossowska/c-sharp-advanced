using System;

namespace EventsIntroWithComments
{
    class Newsletter
    {
        // Important concepts about the events:
        // 1. Publisher - class which raises an event
        // 2. Subscriber - class which receives an event and handles it as it's needed.
        // 3. Internally an event stores the "list" of pointers to the methods (event handlers) to call when an event is raised.
        //    But to call these methods we must know what arguments to pass.
        // 4. We use a Delegate as a "Contract" between the event and all the methods that will be called.
        // 5. In other words, a Delegate provides us with the method signatures, thus we know how to call the methods of Subscriber class.

        // This event can cause any method which conforms to Action to be called.
        // Action points to event handlers which return void and take no arguments.
        public event Action Subscribing;

        // Here comes the code I want to be executed when the event fires.
        public void ClickSubscribe()
        {
            // I make sure I have any subscribers before invoking the delegate
            // Then I call all the event handler methods registered with the Subscribing event.
            Subscribing?.Invoke();
            // Same as:
            //if (Subscribing != null)
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
