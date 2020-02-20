using System;

namespace DateModifier
{
    public class DateModifier
    {
        public double GetDifferenceInDays(string firstDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            var days = (startDate - endDate).TotalDays;
            var result = Math.Abs(days);

            return result;
        }
    }
}