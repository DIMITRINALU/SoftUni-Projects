using System;
using System.Linq;

namespace P03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[input, input];
            FillSquareMatrix(squareMatrix);

            int sumPrimaryDiagonal = 0;
            sumPrimaryDiagonal = PrimaryDiagonal(squareMatrix, sumPrimaryDiagonal);

            Console.WriteLine(sumPrimaryDiagonal);
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