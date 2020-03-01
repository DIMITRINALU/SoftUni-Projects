namespace NeedForSpeed
{
    using System;
    using NeedForSpeed.Cars;
    using NeedForSpeed.Motorcycles;

    public class StartUp
    {
        public static void Main()
        {
            SportCar sportCar = new SportCar(300, 30.00);          

            FamilyCar familyCar = new FamilyCar(100, 10.00);           

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(200, 20.00);            

            Vehicle vehicle = new Vehicle(80, 8.00);
            

            Console.WriteLine(sportCar.FuelConsumption);
            sportCar.Drive(2);

            Console.WriteLine(familyCar.FuelConsumption);
            familyCar.Drive(2);

            Console.WriteLine(raceMotorcycle.Fuel);
            raceMotorcycle.Drive(2);

            Console.WriteLine(vehicle.HorsePower);
            vehicle.Drive(2);
        }
    }
}