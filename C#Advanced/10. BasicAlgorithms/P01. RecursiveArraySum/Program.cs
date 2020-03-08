namespace P01.RecursiveArraySum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int result = Sum(array, index);

            Console.WriteLine(result);
        }

        private static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + Sum(array, index + 1);
        }
    }
}