﻿namespace Vehicles.Core.Factories
{
    using System;
    using Vehicles.Common;
    using Vehicles.Models;

    public class VehicleFactory
    {
        public Vehicle ProduceVehicle(string type, double fuelQty, double fuelConsumption)
        {
            Vehicle vehicle = null;

            if (type == "Car")
            {
                vehicle = new Car(fuelQty, fuelConsumption);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQty, fuelConsumption);
            }

            if (vehicle == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidTypeExceptionMessage);
            }

            return vehicle;
        }
    }
}