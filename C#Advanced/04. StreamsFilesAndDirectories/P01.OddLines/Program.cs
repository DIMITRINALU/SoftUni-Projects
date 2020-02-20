﻿using System;
using System.IO;

namespace P01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");

            int count = 0;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                count++;
            }
        }
    }
}
