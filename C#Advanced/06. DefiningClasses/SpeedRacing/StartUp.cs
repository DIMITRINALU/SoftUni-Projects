using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();

                cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var input = command.Split();

                string model = input[1];
                int distance = int.Parse(input[2]);

                Car car = cars.First(c => c.Model == model);

                if (!car.Drive(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            cars.ForEach(Console.WriteLine);
        }
    }    
}