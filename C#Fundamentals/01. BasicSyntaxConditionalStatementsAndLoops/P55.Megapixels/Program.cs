namespace P55.Megapixels
{
    using System;

    class Program
    {
        static void Main()
        {
            int resolutionWidth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());

            double megapixels = Math.Round(resolutionWidth * resolutionHeight / 1000000.0, 1);

            Console.WriteLine($"{resolutionWidth}x{resolutionHeight} => {megapixels}MP");
        }
    }
}