using System;
using System.Linq;

namespace P06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];
            FillJaggedArray(rows, array);

            while (true)
            {
                string commands = Console.ReadLine().ToLower();

                if (commands == "end")
                {
                    foreach (var currentRow in array)
                    {
                        Console.WriteLine(string.Join(" ", currentRow));
                    }

                    break;
                }

                string[] command = commands.Split();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row >= rows || col < 0 || col >= array[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command[0] == "add")
                {
                    array[row][col] += value;
                }
                else if (command[0] == "subtract")
                {
                    array[row][col] -= value;
                }
            }
        }

        private static void FillJaggedArray(int rows, int[][] array)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                array[row] = currentRow;
            }
        }
    }
}