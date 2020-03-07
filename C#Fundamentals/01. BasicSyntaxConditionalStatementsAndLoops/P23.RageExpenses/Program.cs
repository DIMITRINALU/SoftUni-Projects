namespace P23.RageExpenses
{
    using System;

    class Program
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expences = 0;

            for (int currentGame = 1; currentGame <= lostGamesCount; currentGame++)
            {
                if (currentGame % 2 == 0)
                {
                    expences += headsetPrice;
                }

                if (currentGame % 3 == 0)
                {
                    expences += mousePrice;
                }

                if (currentGame % 6 == 0)
                {
                    expences += keyboardPrice;
                }

                if (currentGame % 12 == 0)
                {
                    expences += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {expences:F2} lv."); 
        }
    }
}