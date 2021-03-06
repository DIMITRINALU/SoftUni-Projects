﻿namespace HotelReservation
{
    public static class PriceCalculator
    {   
        public static decimal GetTotalPrice(
            decimal pricePerDay,
            int days,
            Season season,
            Discount discount = Discount.None)
        {
            var price = days * pricePerDay * (int) season;
            price -= (int) discount * price / 100;

            return price;
        }        
    }
}