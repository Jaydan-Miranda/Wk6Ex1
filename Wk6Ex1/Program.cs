using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex1
{
    internal class Program
    {
        // Vehicle parent class
        class Vehicle
        {
            public string Make { get; set; } // collects the make of the car 
            public string Model { get; set; } // collects the model of the car
            public int Year { get; set; } // collects the year of the car
            public int MaxSpeed { get; set; } // collects the max speed of the car

            // Constructor to initialize the Vehicle class
            public Vehicle(string make, string model, int year, int maxSpeed) 
            {
                //assigns car properties
                Make = make; 
                Model = model;
                Year = year;
                MaxSpeed = maxSpeed;
            }

            // Method to display the vehicle information
            public void DisplayInfo()
            {
                Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Max Speed: {MaxSpeed} km/h");
            }

            // Car class
            public class Car
            {
                private Vehicle vehicle; // initializes the vehicle class
                public int NumberOfDoors { get; set; } // collects the number of doors of the car

                public Car(string make, string model, int year, int maxSpeed, int numberOfDoors) // constructor to initialize the car class
                {
                    vehicle = new Vehicle(make, model, year, maxSpeed); // assigns the vehicle properties
                    NumberOfDoors = numberOfDoors; // assigns the number of doors separately as it is not in the vehicle class
                }
                // Method to display the car information and the number of doors if the car class is called
                public void DisplayInfo()
                {
                    vehicle.DisplayInfo();
                    Console.WriteLine($"Number of Doors: {NumberOfDoors}");
                }
            }

            // Motorcycle class
            public class Motorcycle
            {
                private Vehicle vehicle; // initializes the vehicle class
                public bool HasSidecar { get; set; } // checks if the motorcycle has a sidecar

                public Motorcycle(string make, string model, int year, int maxSpeed, bool hasSidecar) // constructor to initialize the motorcycle class
                {
                    vehicle = new Vehicle(make, model, year, maxSpeed); // assigns the vehicle properties
                    HasSidecar = hasSidecar; // assigns the sidecar property separately as it is not in the vehicle class
                }

                // Method to display the motorcycle information and if it has a sidecar if the motorcycle class is called
                public void DisplayInfo()
                {
                    vehicle.DisplayInfo();
                    Console.WriteLine($"Has Sidecar: {HasSidecar}");
                }
            }
        }

        static void Main(string[] args)
        {
            Vehicle.Car myCar = new Vehicle.Car("Toyota", "Camry", 2022, 240, 4); // creates a new car object
            Vehicle.Motorcycle myMotorcycle = new Vehicle.Motorcycle("Harley Davidson", "Cruiser", 2019, 180, false); // creates a new motorcycle object

            Console.WriteLine("Car Information:");
            myCar.DisplayInfo();
            Console.WriteLine("\nMotorcycle Information:");
            myMotorcycle.DisplayInfo();

            Console.ReadLine();
        }
    }
}
