namespace Vehicles.Models
{
    using System;
    using Vehicles.Common;
    using Vehicles.Models.Contracts;

    public abstract class Vehicle : IDriveable, IRefuelable
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; protected set; }

        public string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionMessages
                    .NotEnoughFuelExceptionMessage, 
                    this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {kilometers} km";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount > 0)
            {
                this.FuelQuantity += fuelAmount;
            }            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}