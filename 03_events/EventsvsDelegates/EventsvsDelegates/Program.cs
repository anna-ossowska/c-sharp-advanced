using System;

namespace EventsvsDelegates
{
    class TrainSignal
    {
        public event Action TrainIsComing;

        public void HereComesATrain()
        {
            // some logic...
            if (TrainIsComing != null)
            {
                TrainIsComing();
            }   
        }
    }

    class Car
    {
        public Car(TrainSignal trainSignal)
        {
            // We are observing the trainSignal
            // When something happens, the trainSignal notifies us via the StopTheCar method
            trainSignal.TrainIsComing += StopTheCar;
        }

        void StopTheCar()
        {
            Console.WriteLine("Screetch");
        }

    }

    class Program
    {
        static void Main()
        {
            TrainSignal trainSignal = new TrainSignal();
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            trainSignal.HereComesATrain();

            // Event is a delegate reference with two restrictions on it:
            // 1. You cannot invoke the delegate reference directly
            // 2. You cannot assign to it directly

            // Thus, this code cannot compile:
            // trainSignal.TrainIsComing();
            // trainSignal.TrainIsComing = null;

            // Thus, this code can compile:
            trainSignal.TrainIsComing += null;
        }
    }
}

