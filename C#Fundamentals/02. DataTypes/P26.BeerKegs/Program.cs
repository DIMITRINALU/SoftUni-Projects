namespace P26.BeerKegs
{
    using System;

    class Program
    {
        static void Main()
        {
            int kegsCounter = int.Parse(Console.ReadLine());
            string biggestKeg = "";            
            double maxVolume = 0;
            
            while (kegsCounter > 0)
            {
                
                string currentKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * radius * radius * height;

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                    biggestKeg = currentKeg;
                }

                kegsCounter--;
            }

            Console.WriteLine(biggestKeg);          
        }
    }
}