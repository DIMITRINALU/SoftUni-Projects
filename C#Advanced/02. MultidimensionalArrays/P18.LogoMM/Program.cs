namespace P18.LogoMM
{
    using System;
    class Program
    {
        static char[,] matrix;        
        static int n;
        static int rows;
        static int cols; 

        static void Main()
        {
            n = int.Parse(Console.ReadLine());

            rows = n + 1;
            cols = n * 10;

            matrix = new char[rows, cols];

            InitializeMatrix();
            FillMatrix();
            PrintMatrix();
        }
        private static void PrintMatrix()
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
        private static void FillMatrix() 
        {            
            int counter = 0;
            
            while (counter < 10)
            {
                int currentCol = counter * n;

                if (counter == 0 || counter == 5)
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = currentCol; col < currentCol + n - row; col++)
                        {
                            matrix[row, col] = '-';
                        }
                    }
                }
                else if (counter == 1 || counter == 3 || counter == 6 || counter == 8)
                {
                    for (int row = rows / 2; row < rows; row++)
                    {
                        for (int col = currentCol + n / 2; col < currentCol + row; col++)
                        {
                            matrix[row, col] = '-';
                        }                        
                    }

                    for (int row = rows / 2; row < rows; row++)
                    {
                        for (int col = ((currentCol--) + n / 2); col < currentCol + row; col++)
                        {
                            matrix[row, col] = '-';
                        }
                    }
                }
                else if (counter == 2 || counter == 7)
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = currentCol + row; col < currentCol + n - row; col++)
                        {
                            matrix[row, col] = '-';
                        }
                    }
                }
                else if (counter == 4 || counter == 9)
                {
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = currentCol + row; col < currentCol + n; col++)
                        {
                            matrix[row, col] = '-';
                        }
                    }
                }                                       

                counter++;
            } 
        }
        private static void InitializeMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = '*';
                }
            }
        }
    }
}