using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string model = input[0];

                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);

                int weigth = int.Parse(input[3]);
                string type = input[4];

                Tire[] tires = new Tire[4];

                int counter = 0;

                for (int tireIndex = 5; tireIndex < input.Length; tireIndex += 2)
                {
                    double currentTirePressure = double.Parse(input[tireIndex]);
                    int currentTireAge = int.Parse(input[tireIndex + 1]);

                    Tire tire = new Tire(currentTirePressure, currentTireAge);

                    tires[counter++] = tire;
                }

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weigth, type);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "flamable")
            {
                cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else if (cargoType == "fragile")
            {
                cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }        
    }
}