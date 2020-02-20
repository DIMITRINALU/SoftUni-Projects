using System;
using System.Collections.Generic;

namespace P13.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ");
                string color = tokens[0];

                string[] clothes = tokens[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] clothing = Console.ReadLine().Split();
            string clothingColor = clothing[0];
            string clothingPiece = clothing[1];

            foreach (var (color, clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (item,piece) in clothes)
                {
                    Console.Write($"* {item} - {piece}");

                    if (item == clothingPiece && clothingColor == color)
                    {
                        Console.Write($" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}