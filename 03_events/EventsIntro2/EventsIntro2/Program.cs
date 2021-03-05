using System;

namespace EventsIntro2
{
    public delegate void Notify(); // delegate

    public class ProcessBusinessLogic // Publisher
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("The process has started...");
            OnProcessCompleted(); // raising an event
        }

        protected virtual void OnProcessCompleted()
        {
            // if ProcessCompleted is not null then call delegate
            // this will call all the event handler methods registered with the ProcessCompleted event.
            ProcessCompleted?.Invoke();
        }

    }

    class Program
    {
        static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process completed!");
        }
    }
}
