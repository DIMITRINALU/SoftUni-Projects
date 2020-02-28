namespace JediGalaxy
{
    using System;    
    using System.Linq;   

    public class Engine
    {
        private int[,] matrix;
        private long sum;

        public Engine()
        {

        }

        public void Run()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int r = dimensions[0];
            int c = dimensions[1];

            this.InitializeMatrix(r, c);

            sum = 0;

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                this.ProcessCoordinates(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }
        private void ProcessCoordinates(string command)
        {
            int[] ivoCoordinates = command
                                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] evilCoordinates = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.EvilMoove(evilCoordinates);

            this.IvoMove(ivoCoordinates);
        }

        private void IvoMove(int[] ivoCoordinates)
        {
            int ivoRow = ivoCoordinates[0];
            int ivoCol = ivoCoordinates[1];

            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (this.IsInsideTheMatrix(ivoRow, ivoCol))
                {
                    sum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }
        }

        private void EvilMoove(int[] evilCoordinates)
        {
            int evilRow = evilCoordinates[0];
            int evilCol = evilCoordinates[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (this.IsInsideTheMatrix(evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0;
                }

                evilRow--;
                evilCol--;
            }
        }

        private bool IsInsideTheMatrix(int row, int col)
        {
            bool isInside = row >= 0 && row < matrix.GetLength(0) &&
                            col >= 0 && col < matrix.GetLength(1);

            return isInside;
        }

        private void InitializeMatrix(int r, int c)
        {
            matrix = new int[r, c];

            int currentNumber = 0;

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }
    }
}    