using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());
            ProcessEngineInput(engines, count);

            count = int.Parse(Console.ReadLine());
            NewMethod(engines, cars, count);

            cars.ForEach(Console.WriteLine);
        }

        private static void NewMethod(HashSet<Engine> engines, List<Car> cars, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var carInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = null;

                string model = carInput[0];
                Engine engine = engines.First(e => e.Model == carInput[1]);

                if (carInput.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carInput.Length == 3)
                {
                    if (carInput[2].All(Char.IsDigit))
                    {
                        int weight = int.Parse(carInput[2]);

                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = carInput[2];

                        car = new Car(model, engine, color);
                    }
                }
                else if (carInput.Length == 4)
                {
                    int weight = int.Parse(carInput[2]);
                    string color = carInput[3];

                    car = new Car(model, engine, weight, color);
                }

                if (car != null)
                {
                    cars.Add(car);
                }
            }
        }

        private static void ProcessEngineInput(HashSet<Engine> engines, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var engineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = null;

                string model = engineInput[0];
                int power = int.Parse(engineInput[1]);

                if (engineInput.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineInput.Length == 3)
                {
                    if (engineInput[2].All(Char.IsDigit))
                    {
                        int displacement = int.Parse(engineInput[2]);
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineInput[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if (engineInput.Length == 4)
                {
                    int displacement = int.Parse(engineInput[2]);
                    string efficiency = engineInput[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }

                if (engine != null)
                {
                    engines.Add(engine);
                }
            }
        }
    }
}