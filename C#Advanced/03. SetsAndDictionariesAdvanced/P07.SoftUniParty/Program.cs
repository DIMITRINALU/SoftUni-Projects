using System;
using System.Collections.Generic;

namespace P07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            string command = Console.ReadLine();            

            while (command != "PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vipGuests.Add(command);
                }
                else
                {
                    regularGuests.Add(command);
                }               

                command = Console.ReadLine();
            }

            while (command != "END")
            {
                if (vipGuests.Contains(command))
                {
                    vipGuests.Remove(command);
                }
                else
                {
                    regularGuests.Remove(command);
                }

                command = Console.ReadLine();
            }

            int guestsCount = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(guestsCount);

            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}