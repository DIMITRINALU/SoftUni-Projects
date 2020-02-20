using System;
using System.Linq;

namespace P11.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            string commands = Console.ReadLine();

            while (!commands.Equals("END"))
            {
                string[] tokens = commands.Split();                             

                if (tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    commands = Console.ReadLine();
                    continue;
                }

                string command = tokens[0];
                int row1 = int.Parse(tokens[1]);
                int col1 = int.Parse(tokens[2]);
                int row2 = int.Parse(tokens[3]);
                int col2 = int.Parse(tokens[4]);

                if (command != "swap" || row1 < 0 || row1 >= dimensions[0]||
                                      row2 < 0|| row2 >= dimensions[0] ||
                                      col1 < 0|| col1 >= dimensions[1] ||
                                      col2 < 0 || col2 >= dimensions[1])
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }

                        Console.WriteLine();
                    }
                }

                commands = Console.ReadLine();
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentElement = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentElement[col];
                }
            }
        }
    }
}