using System;
using System.Linq;

namespace P09._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            int equalSquares = 0;
            equalSquares = FindEqualSquares(matrix, equalSquares);

            Console.WriteLine(equalSquares);
        }

        private static int FindEqualSquares(char[,] matrix, int equalSquares)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentChar = matrix[row, col];

                    bool areEqual = currentChar == matrix[row, col + 1] &&
                                    currentChar == matrix[row + 1, col] &&
                                    currentChar == matrix[row + 1, col + 1];

                    if (areEqual)
                    {
                        equalSquares++;
                    }
                }
            }

            return equalSquares;
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}