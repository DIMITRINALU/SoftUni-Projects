namespace P16.Vacation
{
    using System;

    class Program
    {
        static void Main()
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double pricePerPax = 0;

            if (groupType == "Students")
            {
                if (weekDay == "Friday")
                {
                    pricePerPax = 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPax = 9.80;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPax = 10.46;
                }

            }
            else if (groupType == "Business")
            {
                if (weekDay == "Friday")
                {
                    pricePerPax = 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPax = 15.60;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPax = 16.00;
                }
            }
            else if (groupType == "Regular")
            {
                if (weekDay == "Friday")
                {
                    pricePerPax = 15.00;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPax = 20.00;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPax = 22.50;
                }
            }

            double totalPrice = groupOfPeople * pricePerPax;

            if (groupType == "Students" && groupOfPeople >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (groupType == "Business" && groupOfPeople >= 100)
            {
                totalPrice -= pricePerPax * 10;
            }
            else if (groupType == "Regular" && groupOfPeople >= 10 && groupOfPeople <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}