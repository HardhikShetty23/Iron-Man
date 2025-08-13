using System;

namespace Vehicle
{
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
    }

    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Bike is stopping...");
        }
    }

    public class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Truck is stopping...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            IVehicle bike = new Bike();
            IVehicle truck = new Truck();

            Console.WriteLine("Starting all vehicles:");
            car.Start();
            bike.Start();
            truck.Start();

            Console.WriteLine("\nStopping all vehicles:");
            car.Stop();
            bike.Stop();
            truck.Stop();
        }
    }
}
