using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)      
        {            
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                var tireInfo = command.Split();

                var currTires = new Tire[4]
                {
                new Tire(int.Parse(tireInfo[0]),double.Parse(tireInfo[1])),
                new Tire(int.Parse(tireInfo[2]),double.Parse(tireInfo[3])),
                new Tire(int.Parse(tireInfo[4]),double.Parse(tireInfo[5])),
                new Tire(int.Parse(tireInfo[6]),double.Parse(tireInfo[7]))
                };

                tires.Add(currTires);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                var engineInfo = command.Split();

                var currHorsepower = int.Parse(engineInfo[0]);
                var curCubicCapacity = double.Parse(engineInfo[1]);

                engines.Add(new Engine(currHorsepower, curCubicCapacity));

                command = Console.ReadLine();
            }

            command = Console.ReadLine(); 

            while (command != "Show special")
            {
                var carInfo = command.Split();

                var make = carInfo[0];
                var model = carInfo[1];
                var year = int.Parse(carInfo[2]);
                var fuelQuantity = int.Parse(carInfo[3]);
                var fuelConsumption = int.Parse(carInfo[4]);
                var engineIndex = int.Parse(carInfo[5]);
                var tiresIndex = int.Parse(carInfo[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));

                command = Console.ReadLine();
            }

            foreach (var currenCar in cars)
            {
                bool yearManufactured = false;
                bool horsePower = false;
                bool pressure = false;
                double totalValue = 0;

                if (currenCar.Year >= 2017)
                {
                    yearManufactured = true;
                }

                if (currenCar.Engine.HorsePower >= 330)
                {
                    horsePower = true;
                }

                foreach (var currTires in currenCar.Tires)
                {
                    double value = currTires.Pressure;
                    totalValue += value;
                }

                if (totalValue >= 9 && totalValue <= 10)
                {
                    pressure = true;
                }

                if (yearManufactured && horsePower && pressure)
                {
                    currenCar.Drive(20);
                    Console.WriteLine($"Make: {currenCar.Make}\nModel: {currenCar.Model}\nYear: {currenCar.Year}\nHorsePowers: {currenCar.Engine.HorsePower}\nFuelQuantity: {currenCar.FuelQuantity}");
                }
            }
        }
    }
}