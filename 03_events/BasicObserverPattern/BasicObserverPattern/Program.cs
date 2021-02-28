using System;

namespace BasicObserverPattern
{
    class TrainSignal
    {
        // delegate reference
        public Action TrainIsComing;

        public void HereComesATrain()
        {
            // some logic...
            TrainIsComing();
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
        }
    }
}
