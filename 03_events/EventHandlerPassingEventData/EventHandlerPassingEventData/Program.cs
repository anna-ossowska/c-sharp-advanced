using System;

namespace EventHandlerPassingEventData
{
    // Use the EventHandler<TEventArgs> delegate for all events that include event data

    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed successfully" : "Failed"));
        }
    }

    class ProcessBusinessLogic
    {
        // declaring an event using the built-in EventHandler
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");
                OnProcessCompleted(true); // passing event data
            }

            catch (Exception)
            {
                OnProcessCompleted(false);
            }
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}
