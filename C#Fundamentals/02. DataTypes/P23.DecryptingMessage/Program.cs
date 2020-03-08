namespace P23.DecryptingMessage
{
    using System;

    class Program
    {
        static void Main()
        {
            byte key = byte.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());
            string message = String.Empty;

            while (lines > 0)
            {
                char letter = char.Parse(Console.ReadLine());

                char currentLetter = (char)(letter + key);
                message += currentLetter;

                lines--;
            }          

            Console.WriteLine(message);            
        }
    }
}