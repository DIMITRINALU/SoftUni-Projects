using System;
using System.Linq;

namespace P08.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[size, size];
            FillSquareMatrix(squareMatrix);

            int sumPrimaryDiagonal = 0;
            sumPrimaryDiagonal = PrimaryDiagonal(squareMatrix, sumPrimaryDiagonal);

            int sumSecondaryDiagonal = 0;
            sumSecondaryDiagonal = SecondaryDiagonal(squareMatrix, sumSecondaryDiagonal);

            int difference = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);

            Console.WriteLine(difference);
        }

        private static int SecondaryDiagonal(int[,] squareMatrix, int sumSecondaryDiagonal)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                sumSecondaryDiagonal += squareMatrix[row, squareMatrix.GetLength(0) - row - 1];
            }

            return sumSecondaryDiagonal;
        }

        private static int PrimaryDiagonal(int[,] squareMatrix, int sumPrimaryDiagonal)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                sumPrimaryDiagonal += squareMatrix[row, row];
            }

            return sumPrimaryDiagonal;
        }

        private static void FillSquareMatrix(int[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = colElements[col];
                }
            }
        }
    }
}