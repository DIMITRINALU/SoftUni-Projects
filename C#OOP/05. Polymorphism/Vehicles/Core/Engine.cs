namespace Vehicles.Core
{
    using System;
    using System.Linq;
        
    using Vehicles.Models;
    using Vehicles.Core.Contracts;
    using Vehicles.Core.Factories;

    public class Engine : IEngine
    {
        private readonly VehicleFactory vehicleFactory;       

        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();
        }

        public void Run()
        {
            Vehicle car = ProduceVehicle();
            Vehicle truck = ProduceVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                try
                {
                    ProcessCommand(car, truck, commandArgs);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }              
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ProcessCommand(Vehicle car, Vehicle truck, string[] commandArgs)
        {
            string commandType = commandArgs[0];
            string vehicleType = commandArgs[1];
            double argument = double.Parse(commandArgs[2]);

            if (commandType == "Drive")
            {
                if (vehicleType == "Car")
                {
                    Console.WriteLine(car.Drive(argument)); 
                }
                else if (vehicleType == "Truck")
                {
                    Console.WriteLine(truck.Drive(argument));
                }
            }
            else if (commandType == "Refuel")
            {
                if (vehicleType == "Car")
                {
                    car.Refuel(argument);
                }
                else if (vehicleType == "Truck")
                {
                    truck.Refuel(argument);
                }
            }
        }

        private Vehicle ProduceVehicle()
        {
            string[] vehicleArgs = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();


            string type = vehicleArgs[0];
            double fuelQty = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);

            Vehicle vehicle = this.vehicleFactory.ProduceVehicle(type, fuelQty, fuelConsumption);

            return vehicle;
        }
    }
}