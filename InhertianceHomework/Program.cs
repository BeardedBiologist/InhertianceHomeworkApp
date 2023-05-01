using System;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car instance
            var car = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022,
                Price = 25000.0,
                NumDoors = 4,
                NumWheels = 4,
                HasSunroof = false
            };

            // Create a Boat instance
            var boat = new Boat
            {
                Make = "Bayliner",
                Model = "VR4",
                Year = 2021,
                Price = 35000.0,
                MaxSpeed = 50.0,
                WaterlineLength = 20.0,
                HasSail = false
            };

            // Create a Motorcycle instance
            var motorcycle = new Motorcycle
            {
                Make = "Harley-Davidson",
                Model = "Sportster Iron 883",
                Year = 2022,
                Price = 9000.0,
                NumWheels = 2,
                HasFairing = false,
                HasWindshield = false
            };

            // Print out some information about each vehicle
            Console.WriteLine($"Car: {car.Make} {car.Model} ({car.Year}), Price: {car.Price:C}");
            Console.WriteLine($"Boat: {boat.Make} {boat.Model} ({boat.Year}), Price: {boat.Price:C}");
            Console.WriteLine($"Motorcycle: {motorcycle.Make} {motorcycle.Model} ({motorcycle.Year}), Price: {motorcycle.Price:C}");
        }
    }
}