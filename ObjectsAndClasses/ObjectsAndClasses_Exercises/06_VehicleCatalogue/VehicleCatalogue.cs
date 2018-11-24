namespace _06_VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        public string VehicleType { get; set; }

        public string  VehicleModel { get; set; }

        public string VehicleColor { get; set; }

        public int VehivleHorsepower { get; set; }

        public Car( string vehicleModel, string vehicleColor, int vehicleHorsepower)
        {
            VehicleType = "Car";
            VehicleModel = vehicleModel;
            VehicleColor = vehicleColor;
            VehivleHorsepower = vehicleHorsepower;
        }

    }

    public class Truck
    {
        public string VehicleType { get; set; }

        public string VehicleModel { get; set; }

        public string VehicleColor { get; set; }

        public int VehivleHorsepower { get; set; }

        public Truck(string vehicleModel, string vehicleColor, int vehicleHorsepower)
        {
            VehicleType = "Truck";
            VehicleModel = vehicleModel;
            VehicleColor = vehicleColor;
            VehivleHorsepower = vehicleHorsepower;
        }

    }

    public class VehicleCatalogue
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var trucks = new List<Truck>();

            while (true)
            {
                var vehicle = Console.ReadLine().Split();

                if (vehicle[0] == "End")
                {
                    break;
                }

                var vehicleType = vehicle[0].ToLower();
                var vehicleModel = vehicle[1].ToLower();
                var vehicleColor = vehicle[2].ToLower();
                var vehicleHorsepower = int.Parse(vehicle[3]);

                if (vehicleType == "car")
                {
                    var car = new Car(vehicleModel.First().ToString().ToUpper() + vehicleModel.Remove(0, 1).ToLower(), vehicleColor, vehicleHorsepower);
                    cars.Add(car);
                }
                else
                {
                    var truck = new Truck(vehicleModel.First().ToString().ToUpper() + vehicleModel.Remove(0, 1).ToLower(), vehicleColor, vehicleHorsepower);
                    trucks.Add(truck);
                }
            }
            while (true)
            {
                var vehiclesToPrinte = Console.ReadLine();
                if (vehiclesToPrinte == "Close the Catalogue")
                {
                    break;
                }
                var str = vehiclesToPrinte.First().ToString().ToUpper() + vehiclesToPrinte.Remove(0, 1).ToLower();

                var isCar = cars.Any(c => c.VehicleModel.Contains(vehiclesToPrinte));
                // Type: Car
               //Model: Ford
                //Color: green
                //Horsepower: 120


                if (isCar)
                {
                    var indexOfCar = cars.FindIndex(c => c.VehicleModel == vehiclesToPrinte);
                    Console.WriteLine($"Type: {cars[indexOfCar].VehicleType.ToString()}");
                    Console.WriteLine($"Model: {cars[indexOfCar].VehicleModel.ToString()}");
                    Console.WriteLine($"Color: {cars[indexOfCar].VehicleColor.ToLower().ToString()}");
                    Console.WriteLine($"Horsepower: {cars[indexOfCar].VehivleHorsepower.ToString()}");


                }
                else
                {
                    var indexOfTruck = trucks.FindIndex(c => c.VehicleModel == vehiclesToPrinte);
                    Console.WriteLine($"Type: {trucks[indexOfTruck].VehicleType.ToString()}");
                    Console.WriteLine($"Model: {trucks[indexOfTruck].VehicleModel.ToString()}");
                    Console.WriteLine($"Color: {trucks[indexOfTruck].VehicleColor.ToString()}");
                    Console.WriteLine($"Horsepower: {trucks[indexOfTruck].VehivleHorsepower.ToString()}");
                }
            }
            //if (cars.Select(x => x.VehivleHorsepower).Count() ==1 )
            //{
            //    Console.WriteLine($"Cars have average horsepower of: {cars.Select(x=> x.VehivleHorsepower):f2}.");
            //}
            if (cars.Select(x=> x.VehivleHorsepower).Count() > 0)
            {
                var averageCarsHorsePower = cars.Select(x => x.VehivleHorsepower).Average();
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:f2}.");
            }
            if (trucks.Select(x => x.VehivleHorsepower).Count() > 0)
            {
                var averageTruckHorsePower = trucks.Select(x => x.VehivleHorsepower).Average();
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");
            }
            

        }
    }
}
