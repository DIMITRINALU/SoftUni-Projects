namespace P15.LowerOrUpper
{
    using System;

    class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());
            bool result;
            result = Char.IsUpper(letter);

            if (result == true)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}