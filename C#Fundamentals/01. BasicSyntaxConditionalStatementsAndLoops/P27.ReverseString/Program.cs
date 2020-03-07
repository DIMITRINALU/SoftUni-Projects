namespace P27.ReverseString
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            Console.WriteLine(reversedText);
        }
    }
}