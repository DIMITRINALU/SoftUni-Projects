using System;
using System.Collections.Generic;
using System.Linq;

namespace P17.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static bool isDead;

        static void Main(string[] args)
        {
            isDead = false;

            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            matrix = new char[dimensions[0], dimensions[1]];

            FillMatrix();

            string directions = Console.ReadLine();

            foreach (var direction in directions)
            {
                if (direction == 'U')
                {
                    Move(-1, 0);
                }
                else if (direction == 'L')
                {
                    Move(0, -1);
                }
                else if (direction == 'D')
                {
                    Move(1, 0);
                }
                else if (direction == 'R')
                {
                    Move(0, 1);
                }

                SpreadBunnies();

                if (isDead)
                {
                    Print();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");                   
                    Environment.Exit(0);

                }
            }
        }

        private static void SpreadBunnies()
        {
            List<int> bunniesIndexes = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesIndexes.Add(row);
                        bunniesIndexes.Add(col);
                    }
                }
            }

            for (int i = 0; i < bunniesIndexes.Count; i+=2)
            {
                int bunnyRow = bunniesIndexes[i];
                int bunnyCol = bunniesIndexes[i + 1];

                if (InsideMatrix(bunnyRow, bunnyCol + 1))
                {
                    if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }

                if (InsideMatrix(bunnyRow, bunnyCol - 1))
                {
                    if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }

                if (InsideMatrix(bunnyRow + 1, bunnyCol))
                {
                    if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }

                if (InsideMatrix(bunnyRow - 1, bunnyCol))
                {
                    if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow - 1, bunnyCol] = 'B';
                }
            }
        }

        private static void Move(int row, int col)
        {
            if (!InsideMatrix(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '.';
                SpreadBunnies();
                Print();
                Console.WriteLine($"won: {playerRow} {playerCol}");                
                Environment.Exit(0);
            }

            if (matrix[playerRow + row, playerCol + col] == 'B')
            {
                SpreadBunnies();
                Print();
                Console.WriteLine($"dead: {playerRow + row} {playerCol + col}");                
                Environment.Exit(0);
            }

            matrix[playerRow, playerCol] = '.';

            playerRow += row;
            playerCol += col;

            matrix[playerRow, playerCol] = 'P';
        }

        private static void Print()
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

        private static bool InsideMatrix(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}