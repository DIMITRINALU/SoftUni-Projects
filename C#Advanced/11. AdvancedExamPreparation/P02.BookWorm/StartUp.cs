namespace P02.BookWorm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            char[] initialWord = Console.ReadLine()
                .ToCharArray();

            var word = new Stack<char>(initialWord);

            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];

            int playerRow = 0;
            int playerCol = 0;
            bool playerPositionFound = false;
            InitializeField(size, field, ref playerRow, ref playerCol, ref playerPositionFound);

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        playerRow--;

                        char symbol = field[playerRow][playerCol];

                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow + 1][playerCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 < size)
                    {
                        playerRow++;

                        char symbol = field[playerRow][playerCol];

                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow - 1][playerCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;

                        char symbol = field[playerRow][playerCol];

                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol + 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 < size)
                    {
                        playerCol++;

                        char symbol = field[playerRow][playerCol];

                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol - 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("", word.Reverse()));
            PrintField(field);
        }

        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void Punish(Stack<char> word)
        {
            if (word.Count > 0)
            {
                word.Pop();
            }
        }

        private static void InitializeField(int size, char[][] field, ref int playerRow, ref int playerCol, ref bool playerPositionFound)
        {
            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                field[row] = currentRow;

                if (!playerPositionFound)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'P')
                        {
                            playerRow = row;
                            playerCol = col;
                            playerPositionFound = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}