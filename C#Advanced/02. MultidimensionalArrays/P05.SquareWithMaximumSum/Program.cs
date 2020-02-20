using System;
using System.Linq;

namespace P05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];
            FillMatrix(matrix);

            int maxSquareSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            MaxSquareSum(matrix, ref maxSquareSum, ref maxRowIndex, ref maxColIndex);
            TopLeftSquare(matrix, maxRowIndex, maxColIndex);

            Console.WriteLine(maxSquareSum);
        }

        private static void TopLeftSquare(int[,] matrix, int maxRowIndex, int maxColIndex)
        {
            for (int row = maxRowIndex; row < maxRowIndex + 2; row++)
            {
                for (int col = maxColIndex; col < maxColIndex + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void MaxSquareSum(int[,] matrix, ref int maxSquareSum, ref int maxRowIndex, ref int maxColIndex)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int newSquareSum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];

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
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}