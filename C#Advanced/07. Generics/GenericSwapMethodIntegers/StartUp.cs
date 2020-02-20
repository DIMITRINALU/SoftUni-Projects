namespace GenericSwapMethodIntegers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfBoxes = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfBoxes; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Values.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}