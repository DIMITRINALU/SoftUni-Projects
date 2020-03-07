namespace P24.SortNumbers
{
    using System;

    class Program
    {
        static void Main()
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int largest = Math.Max(Math.Max(firstNum, secondNum), thirdNum); 

            if (largest == thirdNum)
            {
                Console.WriteLine(thirdNum);
                Console.WriteLine(Math.Max(firstNum, secondNum));
                Console.WriteLine(Math.Min(firstNum, secondNum));
            }
            else if (largest == secondNum)
            {
                Console.WriteLine(secondNum);
                Console.WriteLine(Math.Max(firstNum, thirdNum));
                Console.WriteLine(Math.Min(firstNum, thirdNum));
            }
            else
            {
                Console.WriteLine(firstNum);
                Console.WriteLine(Math.Max(secondNum, thirdNum));
                Console.WriteLine(Math.Min(secondNum, thirdNum));
            }            
        }
    }
}