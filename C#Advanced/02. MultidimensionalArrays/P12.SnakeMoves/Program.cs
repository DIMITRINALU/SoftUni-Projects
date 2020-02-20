using System;
using System.Linq;
using System.Text;

namespace P12.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            int snakeLength = snake.Length;
            int snakePathLength = dimensions[0] * dimensions[1];
            int firstPath = snakePathLength / snakeLength;
            int secondPath = snakePathLength % snakeLength;
            string substring = snake.Substring(0, secondPath);
            
            StringBuilder snakePath = new StringBuilder();

            for (int i = 0; i < firstPath; i++)
            {
                snakePath.Append(snake);
            }

            snakePath.Append(substring);
            string text = snakePath.ToString();

            FillMatrix(rows, cols, matrix, text);

            PrintMatrix(matrix);
        }

        private static void FillMatrix(int rows, int cols, char[,] matrix, string text)
        {            
            for (int row = 0; row < rows; row++)     
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = text[col];
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = text[cols - col - 1];
                    }
                }

                text = text.Remove(0, cols);
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}