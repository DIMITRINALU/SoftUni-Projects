namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class ProgramEngine
    {
        private readonly List<Car> cars;
        private readonly List<Tire> carTires;

        public ProgramEngine()
        {
            this.cars = new List<Car>();
            this.carTires = new List<Tire>();
        }

        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());
            ProccessInput(lines);

            string command = Console.ReadLine();
            ProccessCommand(command);
        }

        private void ProccessCommand(string command)
        {
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToList();

                PrintInfo(fragile);
            }
            else
            {
                List<string> flamable = cars
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToList();

                PrintInfo(flamable);
            }
        }

        private void ProccessInput(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                            .Split(new[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                double firstTirePressure = double.Parse(parameters[5]);
                int firstTireAge = int.Parse(parameters[6]);

                double secondTirePressure = double.Parse(parameters[7]);
                int secondTireAge = int.Parse(parameters[8]);

                double thirdTirePressure = double.Parse(parameters[9]);
                int thirdTireAge = int.Parse(parameters[10]);

                double fourthTirePressure = double.Parse(parameters[11]);
                int fourthTireAge = int.Parse(parameters[12]);

                Engine engine = this.CreateEngine(engineSpeed, enginePower);
                Cargo cargo = this.CreateCargo(cargoWeight, cargoType);
                ReadTires(parameters);
                Car car = this.CreateCar(model, engine, cargo, carTires);
                this.cars.Add(car);
            }            
        }

        private void PrintInfo(List<string> cars)         
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        private Car CreateCar(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Car car = new Car(model, engine, cargo, tires.ToArray());

            return car;
        }

        private void ReadTires(string[] parameters)
        {
            for (int i = 5; i < 12; i += 2)
            {
                double currentTirePressure = double.Parse(parameters[i]);
                int currentTireAge = int.Parse(parameters[i + 1]);
                Tire currentTire = CreateTire(currentTireAge, currentTirePressure);
                this.carTires.Add(currentTire);
            }
        }

        private Tire CreateTire(int age, double pressure)
        {
            Tire tire = new Tire(age, pressure);

            return tire;
        }

        private Cargo CreateCargo(int weight, string type)
        {
            Cargo cargo = new Cargo(weight, type);

            return cargo;
        }

        private Engine CreateEngine(int speed, int power)
        {
            Engine engine = new Engine(speed, power);

            return engine;
        }
    }
}   