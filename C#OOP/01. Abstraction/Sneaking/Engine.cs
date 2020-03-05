namespace Sneaking
{
    using System;
    using System.Linq;

    public class Engine
    {
        private char[][] room;

        public Engine()
        {

        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            room = new char[n][];            

            int[] samPosition = InitializeRoom(room);

            string command = Console.ReadLine();

            foreach (var move in command)
            {
                UpdateEnemies(room);
                CheckEnemies(room);
                MoveSam(move, room, samPosition);
                ChekNikoladze(room);
            }
        }

        private static void ChekNikoladze(char[][] room)
        {
            for (var line = 0; line < room.Length; line++)
            {
                if (room[line].Contains('N') && room[line].Contains('S'))
                {
                    room[line][Array.IndexOf(room[line], 'N')] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    PrintRoom(room);
                }
            }
        }

        private static void MoveSam(char move, char[][] room, int[] coordinates)
        {
            switch (move)
            {
                case 'U':
                    room[coordinates[0]][coordinates[1]] = '.';
                    room[--coordinates[0]][coordinates[1]] = 'S';
                    break;
                case 'D':
                    room[coordinates[0]][coordinates[1]] = '.';
                    room[++coordinates[0]][coordinates[1]] = 'S';
                    break;
                case 'L':
                    room[coordinates[0]][coordinates[1]] = '.';
                    room[coordinates[0]][--coordinates[1]] = 'S';
                    break;
                case 'R':
                    room[coordinates[0]][coordinates[1]] = '.';
                    room[coordinates[0]][++coordinates[1]] = 'S';
                    break;
                default:
                    break;
            }
        }

        private static void CheckEnemies(char[][] room)
        {
            for (var line = 0; line < room.Length; line++)
            {
                if (room[line].Contains('b') && room[line].Contains('S'))
                {
                    if (Array.IndexOf(room[line], 'b') < Array.IndexOf(room[line], 'S'))
                    {
                        room[line][Array.IndexOf(room[line], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {line}, {Array.IndexOf(room[line], 'X')}");
                        PrintRoom(room);
                    }
                }
                else if (room[line].Contains('d') && room[line].Contains('S'))
                {
                    if (Array.IndexOf(room[line], 'd') > Array.IndexOf(room[line], 'S'))
                    {
                        room[line][Array.IndexOf(room[line], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {line}, {Array.IndexOf(room[line], 'X')}");
                        PrintRoom(room);
                    }
                }
            }
        }

        private static void PrintRoom(char[][] room)
        {
            foreach (var line in room)
            {
                Console.WriteLine(String.Join("", line));
            }

            Environment.Exit(0);
        }

        private static void UpdateEnemies(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                for (int j = 0; j < room[i].Length; j++)
                {
                    if (room[i][j] == 'b')
                    {
                        if (j == room[i].Length - 1)
                        {
                            room[i][j] = 'd';
                        }
                        else
                        {
                            room[i][j] = '.';
                            room[i][++j] = 'b';
                        }
                    }
                    else if (room[i][j] == 'd')
                    {
                        if (j == 0)
                        {
                            room[i][j] = 'b';
                        }
                        else
                        {
                            room[i][j] = '.';
                            room[i][j - 1] = 'd';
                        }
                    }
                }
            }
        }

        private static int[] InitializeRoom(char[][] room)
        {
            int[] coordinates = null;

            for (int i = 0; i < room.Length; i++)
            {
                string line = Console.ReadLine();

                room[i] = line.ToCharArray();

                if (room[i].Contains('S'))
                {
                    coordinates = new int[] { i, Array.IndexOf(room[i], 'S') };
                }
            }

            return coordinates;
        }
    }
}