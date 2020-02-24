namespace P04.MergeFiles
{    
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            List<string> firstFileNumbers = new List<string>();

            using (var reader = new StreamReader("FileOne.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    firstFileNumbers.Add(line);
                    line = reader.ReadLine();
                }
            }

            List<string> secondFileNumbers = new List<string>();

            using (var reader = new StreamReader("FileTwo.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    secondFileNumbers.Add(line);
                    line = reader.ReadLine();
                }
            }

            int resultLength = firstFileNumbers.Count + secondFileNumbers.Count;

            using var writer = new StreamWriter("Output.txt");

            for (int i = 0; i < resultLength / 2; i++)
            {
                writer.WriteLine(firstFileNumbers[i]);
                writer.WriteLine(secondFileNumbers[i]);
            }
        }
    }    
}