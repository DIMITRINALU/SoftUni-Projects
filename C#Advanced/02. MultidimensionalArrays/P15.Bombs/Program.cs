using System;
using System.Linq;

namespace P15.Bombs
{   
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];
            FillMatrix();

            string[] bombsCoordinates = Console.ReadLine().Split();

            foreach (var coordinate in bombsCoordinates)
            {
                int[] bomb = coordinate.Split(',').Select(int.Parse).ToArray();
                int row = bomb[0];
                int col = bomb[1];
                BombCells(row, col);
            }

            PrintCellInfo();
            PrintMatrix();
        }

        private static void PrintCellInfo()
        {
            int aliveCellsCount = 0;
            int aliveCellsSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += matrix[row, col];
                    }                     
                }                
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();                
            }
        }

        private static void BombCells(int row, int col)
        {
            int damage = matrix[row, col];

            if (damage > 0)
            {
                BombCell(row - 1, col - 1, damage);
                BombCell(row - 1, col, damage);
                BombCell(row - 1, col + 1, damage);
                BombCell(row, col - 1, damage);
                BombCell(row, col + 1, damage);
                BombCell(row + 1, col - 1, damage);
                BombCell(row + 1, col, damage);
                BombCell(row + 1, col + 1, damage);
                matrix[row, col] = 0;
            }
        }

        private static void BombCell(int row, int col, int damage)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && matrix[row, col] > 0)
            {
                matrix[row, col] -= damage;
            }
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentCell = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentCell[col];
                }
            }
        }
    }
}