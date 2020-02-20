using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            double days = dateModifier.GetDifferenceInDays(firstDate, secondDate);

            Console.WriteLine(days);
        }
    }
}