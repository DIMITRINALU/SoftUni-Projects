﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();                

                if (input == "End")
                {
                    Console.WriteLine($"{people.Count} people remaining.");
                    break;
                }
                else if (input == "Paid")
                {
                    while (people.Any())
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }
            }            
        }
    }
}