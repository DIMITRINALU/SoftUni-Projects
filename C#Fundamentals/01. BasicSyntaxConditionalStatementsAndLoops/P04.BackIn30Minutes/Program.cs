namespace P04.BackIn30Minutes
{
    using System;

    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes;

            int timePlus30 = timeInMinutes + 30;

            int finalHour = timePlus30 / 60;
            int finalMinutes = timePlus30 % 60;

            if (finalHour >= 24)
            {
                finalHour -= 24;
            }
            if (finalMinutes < 10)
            {
                Console.WriteLine($"{finalHour}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{finalHour}:{finalMinutes}");
            }
        }
    }
}