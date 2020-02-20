using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tire[] tires = new Tire[4];
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                var tireInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


                int counter = 0;

                for (int tireIndex = 0; tireIndex < tireInfo.Length; tireIndex += 2)
                {
                    int currentTireAge = int.Parse(tireInfo[tireIndex]);
                    double currentTirePressure = double.Parse(tireInfo[tireIndex + 1]);

                    Tire tire = new Tire(currentTireAge, currentTirePressure);

                    tires[counter++] = tire;
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                var engineInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = null;

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                engine = new Engine(horsePower, cubicCapacity);

                if (engine != null)
                {
                    engines.Add(engine);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Show special")
            {
                var carInfo = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = null;

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine engine = engines.First(e => e.HorsePower == int.Parse(carInfo[5]));
                int tiresIndex = int.Parse(carInfo[6]);

                car = new Car(make, model, year, fuelQuantity, fuelConsumption);

                if (car != null)
                {
                    cars.Add(car);
                }

                command = Console.ReadLine();
            }

            foreach (var currenCar in cars)
            {
                bool yearManufactured = false;
                bool horsePower = false;
                bool pressure = false;
                double sumPresuure = 0;

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
                    sumPresuure += value;
                }

                if (sumPresuure >= 9 && sumPresuure <= 10)
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
