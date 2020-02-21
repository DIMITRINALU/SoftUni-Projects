namespace P02.PresentDelivery
{
    using System;
    using System.Linq;

    public class Program
    {
        private static char[][] neighborhood;     
        private static int rowSanta;
        private static int colSanta;
        private static int niceKids;     
         
        static void Main()
        {
            int presentsCount = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            neighborhood = new char[size][];
            FillNeighborhood(neighborhood);

            string command;

            while ((command = Console.ReadLine()) != "Christmas morning" && presentsCount > 0)
            {                
                int nextRow = rowSanta;
                int nextCol = colSanta;
                SantaMovement(command, ref nextRow, ref nextCol);
                
                char nextSymbol = neighborhood[nextRow][nextCol];

                if (nextSymbol == 'V')
                {
                    presentsCount--;
                    niceKids++;
                }
                else if (nextSymbol == 'C')
                {                    
                    GiveGiftsToAllAround(ref presentsCount, nextRow, nextCol);
                }
                                
                neighborhood[rowSanta][colSanta] = '-';
                neighborhood[nextRow][nextCol] = 'S';
                                
                rowSanta = nextRow;
                colSanta = nextCol;
            }

            if (command != "Christmas morning" && presentsCount == 0)
            {                
                Console.WriteLine("Santa ran out of presents!");
            }

            PrintNeighborhood(neighborhood);

            int niceKidsLeftCount = CountOfNiceKidsLeft(size);
            
            if (niceKidsLeftCount == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsLeftCount} nice kid/s.");
            }
        }

        private static int CountOfNiceKidsLeft(int size)
        {
            int niceKidsLeftCount = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (neighborhood[row][col] == 'V')
                    {
                        niceKidsLeftCount++;
                    }
                }
            }

            return niceKidsLeftCount;
        }

        private static void PrintNeighborhood(char[][] neighborhood)
        {
            for (int row = 0; row < neighborhood.Length; row++)
            {
                char[] currentRow = neighborhood[row];

                Console.WriteLine(String.Join(" ", currentRow));
            }
        }

        private static void GiveGiftsToAllAround(ref int presentsCount, int nextRow, int nextCol)
        {
            int countOfGiftsGiven = 0;
            
            if (IsKidOnCoordinates(nextRow, nextCol - 1))
            {
                ProceedCookie(nextRow, nextCol - 1, ref countOfGiftsGiven);
            }

            if (IsKidOnCoordinates(nextRow, nextCol + 1))
            {
                ProceedCookie(nextRow, nextCol + 1, ref countOfGiftsGiven);
            }

            if (IsKidOnCoordinates(nextRow - 1, nextCol))
            {                
                ProceedCookie(nextRow - 1, nextCol, ref countOfGiftsGiven);
            }

            if (IsKidOnCoordinates(nextRow + 1, nextCol))
            {
                ProceedCookie(nextRow + 1, nextCol, ref countOfGiftsGiven);
            }
            
            presentsCount -= countOfGiftsGiven;
        }

        private static void ProceedCookie(int nextRow, int nextCol, ref int countOfGiftsGiven)
        {
            if (neighborhood[nextRow][nextCol] == 'V')
            {
                niceKids++;
            }
                        
            neighborhood[nextRow][nextCol] = '-';

            countOfGiftsGiven++;
        }

        private static bool IsKidOnCoordinates(int row, int col)
        {
            return neighborhood[row][col] == 'X' ||
                neighborhood[row][col] == 'V';
        }

        private static void SantaMovement(string command, ref int nextRow, ref int nextCol)
        {
            if (command == "up")
            {
                nextRow--;
            }
            else if (command == "down")
            {
                nextRow++;
            }
            else if (command == "left")
            {
                nextCol--;
            }
            else if (command == "right")
            {
                nextCol++;
            }
        }               

        private static void FillNeighborhood(char[][] neighborhood)
        {
            for (int row = 0; row < neighborhood.Length; row++)
            {
                char[] currentCol = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();

                neighborhood[row] = currentCol;

                for (int col = 0; col < neighborhood[row].Length; col++)
                {
                    char symbol = neighborhood[row][col];

                    if (symbol == 'S')
                    {
                        rowSanta = row;
                        colSanta = col;
                    }                    
                }
            }
        }        
    }
}