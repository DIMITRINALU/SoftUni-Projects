using System;
using System.Linq;

namespace P13.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] array = new double[rows][];
            FillJaggedArray(array);
            AnalyzingArray(rows, array);

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "End")
                {
                    foreach (var currentRow in array)
                    {
                        Console.WriteLine(string.Join(" ", currentRow));
                    }

                    break;
                }

                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < rows && col >= 0 && col < array[row].Length)                    
                {
                    if (command == "Add")
                    {
                        array[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        array[row][col] -= value;
                    }
                }                    
            }
        }

        private static void AnalyzingArray(int rows, double[][] array)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (array[row].Length == array[row + 1].Length)
                {
                    array[row] = array[row].Select(x => x * 2).ToArray();
                    array[row + 1] = array[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    array[row] = array[row].Select(x => x / 2).ToArray();
                    array[row + 1] = array[row + 1].Select(x => x / 2).ToArray();
                }
            }
        }

        private static void FillJaggedArray(double[][] array)
        {
            for (int row = 0; row < array.Length; row++)
            {
                double[] currentRow = Console.ReadLine().Split().Select(double.Parse).ToArray();

                array[row] = currentRow;
            }
        }
    }
}