namespace P33.RectangleArea
{
    using System;

    class Program
    {
        static void Main()
        {
            var rectangleSideA = double.Parse(Console.ReadLine());
            var rectangleSideB = double.Parse(Console.ReadLine());

            var rectangleArea = rectangleSideA * rectangleSideB;

            Console.WriteLine("{0:F2}", rectangleArea);
        }
    }
}