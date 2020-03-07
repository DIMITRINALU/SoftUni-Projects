namespace P32.DebitCardNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:0000} {3:0000}", num1, num2, num3, num4);
        }
    }
}