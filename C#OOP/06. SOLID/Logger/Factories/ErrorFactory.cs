namespace Logger.Factories
{
    using System;
    using System.Globalization;

    using Logger.Common;
    using Logger.Models.Contracts;
    using Logger.Models.Enumerations;
    using Logger.Models.Errors;   

    public class ErrorFactory
    {
        public IError ProduceError(string dateString, string message, string levelString)
        {
            DateTime dateTime;

            try
            {
                dateTime = DateTime
                    .ParseExact(dateString, GlobalConstant.DATE_FORMAT, CultureInfo.InvariantCulture);
            }
            catch (Exception exceptin)
            {
                throw new ArgumentException("Invalid date format!", exceptin);
            }

            bool hasParsed = Enum.TryParse<Level>(levelString, true, out Level level);

            if (!hasParsed)
            {
                throw new ArgumentException("Invalid level type!");
            }

            IError error = new Error(dateTime, message, level);

            return error;
        }
    }
}