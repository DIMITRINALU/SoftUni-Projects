using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();

            int passedCars = 0;           

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < cars; i++)
                    {
                        if (queue.Any())
                        {
                            passedCars++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");                            
                        }
                    }
                }
                else if (command == "end")
                {
                    break;  
                }
                else
                {
                    queue.Enqueue(command);
                }                
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");            
        }
    }
}