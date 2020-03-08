namespace P09.PrintPartOfASCIITable
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());

            for (int i = firstLine; i <= secondLine; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}