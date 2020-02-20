using System;

namespace SpeedRacing
{
	public class Car
	{
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
            set { this.fuelConsumptionPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public bool Drive(double distance)
        {
            var fuelNeeded = distance * FuelConsumptionPerKilometer;

            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }	
}