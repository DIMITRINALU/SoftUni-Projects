using System;
using System.IO;

namespace P02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("Input.txt");
            using var writer = new StreamWriter("Output.txt");

            int count = 1;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                var convertedLine = $"{count}. {line}";

                writer.WriteLine(convertedLine);

                count++;
            }
        }
    }
}
