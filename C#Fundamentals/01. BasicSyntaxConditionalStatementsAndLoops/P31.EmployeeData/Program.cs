﻿namespace P31.EmployeeData
{
    using System;

    class Program
    {
        static void Main()
        {
            var employeeName = Console.ReadLine();
            var employeeAge = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {employeeName}\n"
                            + $"Age: {employeeAge}\n"
                            + $"Employee ID: {employeeID.ToString("00000000")}\n"
                            + $"Salary: {employeeSalary.ToString("0.00")}");
        }
    }
}