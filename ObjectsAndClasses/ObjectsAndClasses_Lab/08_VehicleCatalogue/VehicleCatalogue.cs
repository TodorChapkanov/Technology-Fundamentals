namespace _08_VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePower { get; set; }

        public Car(string[] vehicleInfo)
        {

        }
    }
    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }

        public Truck(string[] vehicleInfo)
        {

        }
    }
    public class VehicleCatalogue
    {
        public static void Main()
        {
            var listOfCars = new List<Car>();
            var listOfTruck = new List<Truck>();

            var vehicle = Console.ReadLine().Split("/");

            while (vehicle[0] != "end")
            {
               var vehicleType = vehicle[0];
               var vehicleBrand = vehicle[1];
                var vehicleModel = vehicle[2];
                var vehicleSpecification = double.Parse(vehicle[3]);
                if (vehicleType == "Car")
                {
                    Car car = new Car(vehicle)
                    {
                        Brand = vehicleBrand,
                        Model = vehicleModel,
                        HorsePower = vehicleSpecification

                    };
                    listOfCars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(vehicle)
                    {
                        Brand = vehicleBrand,
                        Model = vehicleModel,
                        Weight = vehicleSpecification
                    };
                    listOfTruck.Add(truck);
                }
                
                vehicle = Console.ReadLine().Split("/");
            }
            if (listOfCars.Count > 0 )
            {
                Console.WriteLine("Cars:");
                foreach (var car in listOfCars.OrderBy(c => c.Brand))
                {
                    
                        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            
            if (listOfTruck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in listOfTruck.OrderBy(t => t.Brand))
                {
                    
                    
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    


                }
            }
            

        }

    }
}
