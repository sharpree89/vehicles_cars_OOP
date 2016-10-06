using System;

namespace ConsoleApplication_Vehicles
{
    public class Vehicle
    {
        public int numPassengers;
        public double distance = 0.0;
        public Vehicle(int num)
        {
            numPassengers = num;
        }
        public Vehicle(int num, double odo)
        {
            numPassengers = num;
            distance = odo;
        }
        public int Move(double miles)
        {
            distance += miles;
            return (int)distance;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Max Occupancy: {numPassengers}");
            Console.WriteLine($"Current Mileage: {distance} miles");
        }
    }
    public class Car : Vehicle
    {
        public int numWheels = 4;
        public string condition;
        
        public Car() : base(5)
        {
            condition = "New";
        }
        public Car(double odo) : base(5, odo)
        {
            condition = "Used";
        }
        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Car Condition: {condition}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Car oldCar = new Car(167263);
            // Console.WriteLine($"Car Condition: {oldCar.condition}");
            // Console.WriteLine($"Max Occupancy: {oldCar.numPassengers}");
            // oldCar.Move(6.53);
            // Console.WriteLine($"Current Mileage: {oldCar.distance}");
            Vehicle obj1 = new Vehicle(5);
            Car obj2 = new Car(5);
            obj1.GetInfo();
            obj2.GetInfo();
        }
    }
}
