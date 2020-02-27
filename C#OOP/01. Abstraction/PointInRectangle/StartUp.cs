namespace PointInRectangle
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] inputParts = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var topLeftX = inputParts[0];
            var topLeftY = inputParts[1];
            var bottomRightX = inputParts[2];
            var bottomRightY = inputParts[3];
            
            Rectangle rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                inputParts = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)                    
                    .ToArray();

                var x = inputParts[0];
                var y = inputParts[1];

                Point point = new Point(x, y);
                Console.WriteLine(rectangle.Contains(point));
            }            
        }
    }
}