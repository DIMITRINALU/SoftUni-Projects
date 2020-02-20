namespace GenericBoxOfInteger
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(value);
                Console.WriteLine(box);
            }
        }
    }
}