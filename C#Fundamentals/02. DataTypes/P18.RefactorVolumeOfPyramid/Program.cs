namespace P18.RefactorVolumeOfPyramid
{
    using System;

    class Program
    {
        static void Main()            
        {            
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());            
            double height = double.Parse(Console.ReadLine());   
            
            double volume = lenght * width * height / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");
        }
    }
}