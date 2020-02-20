using System;

namespace P14.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];
            FillBoard(chessBoard);

            int knightsCount = 0;            
            int knightRow = 0;
            int knightCol = 0;

            while (true)
            {
                int maxAttacks = 0;
                
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {                        
                        int currentKnightsAttacks = 0;                        

                        if (chessBoard[row, col] == 'K')
                        {
                            currentKnightsAttacks = CheckBoard(chessBoard, row, col, currentKnightsAttacks);
                        }

                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[knightRow, knightCol] = '0';
                    knightsCount++;
                }
                else
                {
                    Console.WriteLine(knightsCount);
                    break;
                }
            }
        }

        private static int CheckBoard(char[,] chessBoard, int row, int col, int currentKnightsAttacks)
        {
            if (IsInsideBoard(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
            {
                currentKnightsAttacks++;
            }

            if (IsInsideBoard(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
            {
                currentKnightsAttacks++;
            }

            return currentKnightsAttacks;
        }

        private static bool IsInsideBoard(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }

        private static void FillBoard(char[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] currentElement = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = currentElement[col];
                }
            }
        }
    }
}