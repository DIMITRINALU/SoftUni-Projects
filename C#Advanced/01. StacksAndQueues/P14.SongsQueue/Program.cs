using System;
using System.Collections.Generic;
using System.Linq;

namespace P14.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");       
            var songsList = new Queue<string>(songs);

            while (songsList.Any())
            {
                string command = Console.ReadLine();
                
                if (command == "Play")
                {
                    songsList.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songsList));
                }
                else 
                {
                    string currentSong = command.Substring(4, command.Length - 4);

                    if (!songsList.Contains(currentSong))
                    {
                        songsList.Enqueue(currentSong);
                    }
                    else
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}