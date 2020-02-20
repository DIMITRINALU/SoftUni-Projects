using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parking = new HashSet<string>();

            while (input != "END")
            {
                string[] cars = input.Split(", ");
                string command = cars[0];
                string car = cars[1];

                if (command == "IN")
                {
                    parking.Add(car);
                }
                else
                {
                    parking.Remove(car);
                }

                input = Console.ReadLine();
            }

            if (parking.Any())
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }                
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}