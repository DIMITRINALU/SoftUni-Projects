using System;
using System.Collections.Generic;
using System.Linq;

namespace P18.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationGreenLight = int.Parse(Console.ReadLine());
            int durationFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string commands = Console.ReadLine();
            bool crash = false;
            string crashedCar = string.Empty;
            int hitIndex = -1;
            int totalCarsPassed = 0;

            while (true)
            {
                if (commands == "END")
                {
                    break;
                }

                if (commands == "green")
                {
                    int currentGreenLight = durationGreenLight;

                    while (currentGreenLight > 0 && cars.Any())
                    {
                        string currentCar = cars.Peek();
                        int carLength = currentCar.Length;

                        if (carLength <= currentGreenLight)
                        {
                            currentGreenLight -= carLength;
                            totalCarsPassed++;
                            cars.Dequeue();
                        }
                        else
                        {
                            carLength -= currentGreenLight;

                            if (carLength <= durationFreeWindow)
                            {
                                totalCarsPassed++;
                                cars.Dequeue();
                            }
                            else
                            {
                                crash = true;
                                crashedCar = currentCar;
                                hitIndex = currentGreenLight + durationFreeWindow;
                                break;
                            }                            
                        }                        
                    }
                }
                else
                {
                    cars.Enqueue(commands);
                }

                if (crash)
                {
                    break;
                }

                commands = Console.ReadLine();
            }

            if (crash)
            {
                Console.WriteLine($"A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
            }
        }
    }
}