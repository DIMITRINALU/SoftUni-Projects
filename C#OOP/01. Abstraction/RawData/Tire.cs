﻿namespace RawData
{   
    public class Tire
    {
        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age { get;  }
        public double Pressure { get; }
    }
}