namespace P02.SpaceStationEstablishment
{
    using System;    

    public class Program
    {
        private static char[][] galaxy;
        private static int stefanRow;
        private static int stefanCol;
        private const int STARS_NEEDED = 50;
        private static int stars = 0;

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            galaxy = new char[size][];
            FillGalaxy(galaxy);            

            while (true)
            {
                galaxy[stefanRow][stefanCol] = '-';
                
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        stefanRow--;
                        break;
                    case "down":
                        stefanRow++;
                        break;
                    case "left":
                        stefanCol--;
                        break;
                    case "right":
                        stefanCol++;
                        break;
                }
                                
                if (IsOutsideGalaxy(stefanRow, stefanCol, size))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                char currentElement = galaxy[stefanRow][stefanCol];

                if (currentElement == 'O')
                {
                    galaxy[stefanRow][stefanCol] = '-';

                    for (int r = 0; r < size; r++)
                    {
                        bool isFound = false;

                        for (int c = 0; c < size; c++)
                        {
                            char currentGalaxyElement = galaxy[r][c];

                            if (currentGalaxyElement == 'O')
                            {
                                stefanRow = r;
                                stefanCol = c;                                                              

                                isFound = true;
                                break;
                            }
                        }

                        if (isFound)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(currentElement))
                {
                    stars += int.Parse(currentElement.ToString());                    
                }

                galaxy[stefanRow][stefanCol] = 'S';

                if (stars >= STARS_NEEDED)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {stars}");
            PrintMatrix(galaxy);
        }                

        private static void PrintMatrix(char[][] galaxy)
        {
            for (int row = 0; row < galaxy.Length; row++)
            {
                char[] currentRow = galaxy[row];

                Console.WriteLine(String.Join("", currentRow));
            }
        }

        private static bool IsOutsideGalaxy(int stefanRow, int stefanCol, int size)
        {
            return stefanRow >= size || stefanRow < 0 || stefanCol >= size || stefanCol < 0;
        }            

        private static void FillGalaxy(char[][] galaxy)
        {            
            for (int row = 0; row < galaxy.Length; row++)
            {
                char[] currentCol = Console.ReadLine()
                    .ToCharArray();

                galaxy[row] = currentCol;

                for (int col = 0; col < galaxy[row].Length; col++)
                {                    
                    char symbol = galaxy[row][col];

                    if (symbol == 'S')
                    {
                        stefanRow = row;
                        stefanCol = col;                       
                    }
                }                
            }
        }
    }
}