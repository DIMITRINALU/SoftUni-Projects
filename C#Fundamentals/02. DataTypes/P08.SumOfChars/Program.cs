namespace P08.SumOfChars
{
    using System;

    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 1;

            while (counter <= lines)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
                counter++;
            }
            
            Console.WriteLine($"The sum equals: {sum}"); 
        }
    }
}