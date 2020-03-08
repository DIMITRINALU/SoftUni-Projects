namespace P24.WaterOverflow
{
    using System;

    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int pourInTank = 0;
            int count = 1;
            
            while (count <= lines)
            {
                int litters = int.Parse(Console.ReadLine());

                if (capacity - pourInTank < litters)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    pourInTank += litters;
                }  
                
                count++;
            }
            
            Console.WriteLine(pourInTank);
        }
    }
}