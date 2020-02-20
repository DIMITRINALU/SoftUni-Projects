namespace P02.ExcelFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] table = new string[rows][];
            FillTable(rows, table);

            string[] commands = Console.ReadLine()
                .Split();

            string command = commands[0];
            string header = commands[1];
            int headerIndex = Array.IndexOf(table[0], header);

            if (command == "hide")
            { 
                for (int row = 0; row < table.Length; row++)
                {
                    var lineToPrint = new List<string>(table[row]);

                    lineToPrint.RemoveAt(headerIndex);                    

                    Console.WriteLine(string.Join(" | ", lineToPrint));                    
                }
            }
            else if (command == "sort")
            {
                string[] headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                table = table.OrderBy(x => x[headerIndex]).ToArray();                               

                foreach (var row in table)
	            {
                    if (row != headerRow)
	                {
                        Console.WriteLine(string.Join(" | ", row));
	                }
	            }
            }
            else if (command == "filter")
            {
                string value = commands[2];
                string[] headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i][headerIndex] == value)
                    {
                        Console.WriteLine(string.Join(" | ", table[i]));
                    }
                }
            }
        }

        private static void FillTable(int rows, string[][] table)
        {
            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(", ");

                table[i] = rowValues;
            }
        }
    }
}