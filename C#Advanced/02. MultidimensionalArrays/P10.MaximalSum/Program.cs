using System;
using System.Linq;

namespace P10.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];
            FillMatrix(matrix);

            int maxSquareSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            MaxSquareSum(matrix, ref maxSquareSum, ref maxRowIndex, ref maxColIndex);            

            Console.WriteLine($"Sum = {maxSquareSum}");

            PrintSquareElememts(matrix, maxRowIndex, maxColIndex);
        }

        private static void PrintSquareElememts(int[,] matrix, int maxRowIndex, int maxColIndex)
        {
            for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
            {
                for (int col = maxColIndex; col < maxColIndex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void MaxSquareSum(int[,] matrix, ref int maxSquareSum, ref int maxRowIndex, ref int maxColIndex)
        {
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int newSquareSum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row, col + 2] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];

                    if (newSquareSum > maxSquareSum)
                    {
                        maxSquareSum = newSquareSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}