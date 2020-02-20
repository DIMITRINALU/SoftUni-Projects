namespace GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.Add(element);
            }

            Box<double> box = new Box<double>(elements);

            double elementToCompare = double.Parse(Console.ReadLine());

            int count = box.CountGreaterElements(elements, elementToCompare);

            Console.WriteLine(count);
        }
    }
}
