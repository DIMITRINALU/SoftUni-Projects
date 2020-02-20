namespace GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                elements.Add(element);
            }

            Box<string> box = new Box<string>(elements);

            string elementToCompare = Console.ReadLine();

            int count = box.CountGreaterElements(elements, elementToCompare);

            Console.WriteLine(count);
        }
    }
}