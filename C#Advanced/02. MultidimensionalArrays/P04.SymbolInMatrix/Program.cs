using System;

namespace P04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[input, input];
            FillSquareMatrix(squareMatrix);

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (squareMatrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        private static void FillSquareMatrix(int[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(0); col++)
                {
                    squareMatrix[row, col] = colElements[col];
                }
            }
        }
    }
}